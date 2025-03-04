namespace sroNumber4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Width = 600;
            this.Height = 500;
            this.Text = "Обработка списка чисел";

            // Кнопка создания списка
            Button btnCreateList = new Button
            {
                Text = "Создать список",
                Location = new System.Drawing.Point(10, 10),
                Width = 150,
                Height = 30
            };
            btnCreateList.Click += BtnCreateList_Click;

            // Кнопка вывода списка
            Button btnDisplayList = new Button
            {
                Text = "Вывести список",
                Location = new System.Drawing.Point(170, 10),
                Width = 150,
                Height = 30

            };
            btnDisplayList.Click += BtnDisplayList_Click;

            // Кнопка подсчета элементов с свойством Q
            Button btnCountQ = new Button
            {
                Text = "Подсчет элементов Q",
                Location = new System.Drawing.Point(10, 40),
                Width = 150,
                Height = 30
            };
            btnCountQ.Click += BtnCountQ_Click;

            // Кнопка удаления элементов с свойством T
            Button btnRemoveT = new Button
            {
                Text = "Удалить элементы T",
                Location = new System.Drawing.Point(170, 40),
                Width = 150,
                Height = 30
            };
            btnRemoveT.Click += BtnRemoveT_Click;

            // Кнопка очистки списка
            Button btnClearList = new Button
            {
                Text = "Очистить список",
                Location = new System.Drawing.Point(330, 10),
                Width = 150,
                Height = 30

            };
            btnClearList.Click += BtnClearList_Click;

            // Текстовое поле для вывода
            txtOutput = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new System.Drawing.Point(10, 80),
                Width = 560,
                Height = 350
            };
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Controls.Add(btnCreateList);
            this.Controls.Add(btnDisplayList);
            this.Controls.Add(btnCountQ);
            this.Controls.Add(btnRemoveT);
            this.Controls.Add(btnClearList);
            this.Controls.Add(txtOutput);
        }
        #endregion

        private Button btnCreateList;
        private Button btnDisplayList;
        private Button btnCountQ;
        private Button btnRemoveT;
        private Button button1;
        private Button btnClearList;
    }
}
