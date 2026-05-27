using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSVFile
{
    public partial class frmTSVFile : Form
    {
        // ── Win32：讓 TextBox 顯示提示文字（.NET Framework 用）────────────
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
        private const int EM_SETCUEBANNER = 0x1501;

        /// <summary>關於視窗</summary>
        frmAbout about = new frmAbout();

        /// <summary>單字清單</summary>
        WordCollection _WordList = new WordCollection();

        // ── 彩色列配置 ─────────────────────────────────────────────────────
        private readonly Color[] _rowColors = new Color[]
        {
            Color.FromArgb(255, 248, 255),  // 淡紫
            Color.FromArgb(255, 253, 245),  // 淡黃
            Color.FromArgb(248, 255, 248),  // 淡綠
            Color.FromArgb(245, 250, 255),  // 淡藍
        };
        private readonly Color _selColor = Color.FromArgb(237, 224, 255);
        private readonly Color _selForeWord = Color.FromArgb(136, 0, 187);
        private readonly Color _foreWord = Color.FromArgb(170, 17, 204);
        private readonly Color _forePhono = Color.FromArgb(34, 68, 204);
        private readonly Color _foreExplain = Color.FromArgb(17, 119, 68);
        private readonly Color _foreSound = Color.FromArgb(170, 102, 0);

        public frmTSVFile()
        {
            InitializeComponent();
        }

        // ── 載入完成後設定提示文字 ────────────────────────────────────────
        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            tsslMessage.Text = "";
            // 設定搜尋欄的灰色提示文字（.NET Framework 相容方式）
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, (IntPtr)1, "搜尋單字、音標、中文解釋…");
        }

        // ── 更新 ListView（支援搜尋篩選）─────────────────────────────────
        private void UpdateListView()
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            lvwWord.BeginUpdate();
            lvwWord.Items.Clear();

            foreach (WordItem item in _WordList)
            {
                if (keyword != "" &&
                    !item.Word.ToLower().Contains(keyword) &&
                    !item.Phonogram.ToLower().Contains(keyword) &&
                    !item.Explain.ToLower().Contains(keyword))
                    continue;

                ListViewItem lvi = new ListViewItem(item.Word);
                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);
                lvwWord.Items.Add(lvi);
            }

            lvwWord.EndUpdate();

            tsslMessage.Text = keyword != ""
                ? $"找到 {lvwWord.Items.Count} / {_WordList.Count} 筆"
                : $"{_WordList.Count} 單字已成功載入";
        }

        // ── 搜尋欄即時篩選 ────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        // ── 原始事件（名稱完全不變）──────────────────────────────────────
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            about.ShowDialog(this);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files (*.*) | *.* ";
            ofd.Title = "開啟檔案";
            ofd.InitialDirectory = Application.StartupPath;
            DialogResult dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                _WordList.LoadFromStringArray(lines);
                txtSearch.Text = "";
                UpdateListView();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要離開嗎?", "離開",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        // ── ListView 自訂繪製 ──────────────────────────────────────────────
        private void lvwWord_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Color[] bgColors = {
                Color.FromArgb(255, 232, 248),
                Color.FromArgb(232, 240, 255),
                Color.FromArgb(232, 255, 240),
                Color.FromArgb(255, 243, 224),
            };
            Color[] fgColors = {
                Color.FromArgb(204, 34, 153),
                Color.FromArgb(34, 85, 204),
                Color.FromArgb(17, 153, 68),
                Color.FromArgb(187, 102, 0),
            };
            int idx = Math.Min(e.ColumnIndex, 3);

            using (var b = new SolidBrush(bgColors[idx]))
                e.Graphics.FillRectangle(b, e.Bounds);

            using (var pen = new Pen(Color.FromArgb(221, 208, 240)))
                e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1,
                                        e.Bounds.Right, e.Bounds.Bottom - 1);

            using (var b = new SolidBrush(fgColors[idx]))
            using (var font = new Font("Microsoft JhengHei UI", 9f, FontStyle.Bold))
            {
                var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(e.Header.Text, font, b,
                    new RectangleF(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height), sf);
            }
        }

        private void lvwWord_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = false;
        }

        private void lvwWord_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle r = e.Bounds;

            Color bg = e.Item.Selected
                ? _selColor
                : _rowColors[e.ItemIndex % _rowColors.Length];

            using (var b = new SolidBrush(bg))
                e.Graphics.FillRectangle(b, r);

            using (var pen = new Pen(Color.FromArgb(240, 236, 255)))
                e.Graphics.DrawLine(pen, r.Left, r.Bottom - 1, r.Right, r.Bottom - 1);

            Color fore;
            switch (e.ColumnIndex)
            {
                case 0: fore = e.Item.Selected ? _selForeWord : _foreWord; break;
                case 1: fore = _forePhono; break;
                case 2: fore = _foreSound; break;
                default: fore = _foreExplain; break;
            }

            using (var b = new SolidBrush(fore))
            using (var font = new Font("Microsoft JhengHei UI",
                e.ColumnIndex == 0 ? 9.5f : 9f,
                e.ColumnIndex == 0 ? FontStyle.Bold : FontStyle.Regular))
            {
                var sf = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                e.Graphics.DrawString(e.SubItem.Text, font, b,
                    new RectangleF(r.X + 6, r.Y, r.Width - 8, r.Height), sf);
            }
        }
    }
}