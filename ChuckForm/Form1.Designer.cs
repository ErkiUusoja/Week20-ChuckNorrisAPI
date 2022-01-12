namespace ChuckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokebtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokebtn
            // 
            this.getJokebtn.Location = new System.Drawing.Point(31, 31);
            this.getJokebtn.Name = "getJokebtn";
            this.getJokebtn.Size = new System.Drawing.Size(75, 23);
            this.getJokebtn.TabIndex = 0;
            this.getJokebtn.Text = "Get Joke";
            this.getJokebtn.UseVisualStyleBackColor = true;
            this.getJokebtn.Click += new System.EventHandler(this.getJokebtn_Click_1);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(-1, 143);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(194, 208);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke, i dare you!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.getJokebtn);
            this.Name = "Form1";
            this.Text = "Chuck Norris Jokes Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokebtn;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

