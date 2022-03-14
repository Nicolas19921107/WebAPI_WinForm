using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using WebAPI.Models;
namespace WinForm
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NameOne = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeOne = new System.Windows.Forms.TextBox();
            this.AgeTwo = new System.Windows.Forms.TextBox();
            this.NameTwo = new System.Windows.Forms.TextBox();
            this.AgeThr = new System.Windows.Forms.TextBox();
            this.NameThr = new System.Windows.Forms.TextBox();
            this.AgeFour = new System.Windows.Forms.TextBox();
            this.NameFour = new System.Windows.Forms.TextBox();
            this.ModelBindObjURL = new System.Windows.Forms.TextBox();
            this.ModelBindObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjTitle = new System.Windows.Forms.Label();
            this.SimpleModelBindArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjTitle = new System.Windows.Forms.Label();
            this.ModelBindObjJSON = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JSON = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Urlencoded = new System.Windows.Forms.Label();
            this.SimpleBindingJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingTItle = new System.Windows.Forms.Label();
            this.SimpleBindingURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBindingArrayJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjURL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SimpleModelBindArrayJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(844, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameOne
            // 
            this.NameOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameOne.Location = new System.Drawing.Point(104, 23);
            this.NameOne.Multiline = true;
            this.NameOne.Name = "NameOne";
            this.NameOne.Size = new System.Drawing.Size(179, 38);
            this.NameOne.TabIndex = 13;
            this.NameOne.TextChanged += new System.EventHandler(this.NameOne_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.LightBlue;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(12, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 37);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "姓名";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.LightBlue;
            this.AgeLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeLabel.Location = new System.Drawing.Point(12, 76);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 37);
            this.AgeLabel.TabIndex = 15;
            this.AgeLabel.Text = "年齡";
            // 
            // AgeOne
            // 
            this.AgeOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeOne.Location = new System.Drawing.Point(104, 75);
            this.AgeOne.Multiline = true;
            this.AgeOne.Name = "AgeOne";
            this.AgeOne.Size = new System.Drawing.Size(179, 38);
            this.AgeOne.TabIndex = 16;
            // 
            // AgeTwo
            // 
            this.AgeTwo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeTwo.Location = new System.Drawing.Point(289, 75);
            this.AgeTwo.Multiline = true;
            this.AgeTwo.Name = "AgeTwo";
            this.AgeTwo.Size = new System.Drawing.Size(179, 38);
            this.AgeTwo.TabIndex = 18;
            // 
            // NameTwo
            // 
            this.NameTwo.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTwo.Location = new System.Drawing.Point(289, 23);
            this.NameTwo.Multiline = true;
            this.NameTwo.Name = "NameTwo";
            this.NameTwo.Size = new System.Drawing.Size(179, 38);
            this.NameTwo.TabIndex = 17;
            // 
            // AgeThr
            // 
            this.AgeThr.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeThr.Location = new System.Drawing.Point(474, 75);
            this.AgeThr.Multiline = true;
            this.AgeThr.Name = "AgeThr";
            this.AgeThr.Size = new System.Drawing.Size(179, 38);
            this.AgeThr.TabIndex = 20;
            // 
            // NameThr
            // 
            this.NameThr.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameThr.Location = new System.Drawing.Point(474, 23);
            this.NameThr.Multiline = true;
            this.NameThr.Name = "NameThr";
            this.NameThr.Size = new System.Drawing.Size(179, 38);
            this.NameThr.TabIndex = 19;
            // 
            // AgeFour
            // 
            this.AgeFour.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeFour.Location = new System.Drawing.Point(659, 74);
            this.AgeFour.Multiline = true;
            this.AgeFour.Name = "AgeFour";
            this.AgeFour.Size = new System.Drawing.Size(179, 38);
            this.AgeFour.TabIndex = 22;
            // 
            // NameFour
            // 
            this.NameFour.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameFour.Location = new System.Drawing.Point(659, 22);
            this.NameFour.Multiline = true;
            this.NameFour.Name = "NameFour";
            this.NameFour.Size = new System.Drawing.Size(179, 38);
            this.NameFour.TabIndex = 21;
            // 
            // ModelBindObjURL
            // 
            this.ModelBindObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjURL.Location = new System.Drawing.Point(328, 362);
            this.ModelBindObjURL.Multiline = true;
            this.ModelBindObjURL.Name = "ModelBindObjURL";
            this.ModelBindObjURL.ReadOnly = true;
            this.ModelBindObjURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindObjURL.TabIndex = 23;
            this.ModelBindObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindObjTitle
            // 
            this.ModelBindObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjTitle.Location = new System.Drawing.Point(12, 362);
            this.ModelBindObjTitle.Name = "ModelBindObjTitle";
            this.ModelBindObjTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindObjTitle.TabIndex = 24;
            this.ModelBindObjTitle.Text = "ModelBindingObj";
            this.ModelBindObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayTitle
            // 
            this.ModelBindingArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayTitle.Location = new System.Drawing.Point(612, 136);
            this.ModelBindingArrayTitle.Name = "ModelBindingArrayTitle";
            this.ModelBindingArrayTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindingArrayTitle.TabIndex = 26;
            this.ModelBindingArrayTitle.Text = "ModelBindingArray";
            this.ModelBindingArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjTitle
            // 
            this.ModelBindingNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjTitle.Location = new System.Drawing.Point(612, 362);
            this.ModelBindingNestedObjTitle.Name = "ModelBindingNestedObjTitle";
            this.ModelBindingNestedObjTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindingNestedObjTitle.TabIndex = 28;
            this.ModelBindingNestedObjTitle.Text = "ModelBindingNestedObj";
            this.ModelBindingNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindArrayTitle
            // 
            this.SimpleModelBindArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.SimpleModelBindArrayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayTitle.Location = new System.Drawing.Point(15, 586);
            this.SimpleModelBindArrayTitle.Name = "SimpleModelBindArrayTitle";
            this.SimpleModelBindArrayTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SimpleModelBindArrayTitle.Size = new System.Drawing.Size(185, 200);
            this.SimpleModelBindArrayTitle.TabIndex = 30;
            this.SimpleModelBindArrayTitle.Text = "SimpleModelBindArray";
            this.SimpleModelBindArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjTitle
            // 
            this.ModelBindingArrayNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjTitle.Location = new System.Drawing.Point(612, 583);
            this.ModelBindingArrayNestedObjTitle.Name = "ModelBindingArrayNestedObjTitle";
            this.ModelBindingArrayNestedObjTitle.Size = new System.Drawing.Size(185, 202);
            this.ModelBindingArrayNestedObjTitle.TabIndex = 32;
            this.ModelBindingArrayNestedObjTitle.Text = "ModelBindingArrayNestedObj";
            this.ModelBindingArrayNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindObjJSON
            // 
            this.ModelBindObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjJSON.Location = new System.Drawing.Point(328, 471);
            this.ModelBindObjJSON.Multiline = true;
            this.ModelBindObjJSON.Name = "ModelBindObjJSON";
            this.ModelBindObjJSON.ReadOnly = true;
            this.ModelBindObjJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindObjJSON.TabIndex = 33;
            this.ModelBindObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(203, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 103);
            this.label2.TabIndex = 34;
            this.label2.Text = "Urlencoded";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JSON
            // 
            this.JSON.BackColor = System.Drawing.Color.SkyBlue;
            this.JSON.Enabled = false;
            this.JSON.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JSON.Location = new System.Drawing.Point(203, 471);
            this.JSON.Name = "JSON";
            this.JSON.Size = new System.Drawing.Size(119, 104);
            this.JSON.TabIndex = 35;
            this.JSON.Text = "JSON";
            this.JSON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(203, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 104);
            this.label1.TabIndex = 40;
            this.label1.Text = "JSON";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urlencoded
            // 
            this.Urlencoded.BackColor = System.Drawing.Color.SkyBlue;
            this.Urlencoded.Enabled = false;
            this.Urlencoded.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Urlencoded.Location = new System.Drawing.Point(203, 136);
            this.Urlencoded.Name = "Urlencoded";
            this.Urlencoded.Size = new System.Drawing.Size(119, 103);
            this.Urlencoded.TabIndex = 39;
            this.Urlencoded.Text = "Urlencoded";
            this.Urlencoded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingJSON
            // 
            this.SimpleBindingJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingJSON.Location = new System.Drawing.Point(328, 245);
            this.SimpleBindingJSON.Multiline = true;
            this.SimpleBindingJSON.Name = "SimpleBindingJSON";
            this.SimpleBindingJSON.ReadOnly = true;
            this.SimpleBindingJSON.Size = new System.Drawing.Size(269, 104);
            this.SimpleBindingJSON.TabIndex = 38;
            this.SimpleBindingJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingTItle
            // 
            this.SimpleBindingTItle.BackColor = System.Drawing.Color.Orange;
            this.SimpleBindingTItle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingTItle.Location = new System.Drawing.Point(12, 136);
            this.SimpleBindingTItle.Name = "SimpleBindingTItle";
            this.SimpleBindingTItle.Size = new System.Drawing.Size(185, 213);
            this.SimpleBindingTItle.TabIndex = 37;
            this.SimpleBindingTItle.Text = "SimpleBinding";
            this.SimpleBindingTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingURL
            // 
            this.SimpleBindingURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingURL.Location = new System.Drawing.Point(328, 136);
            this.SimpleBindingURL.Multiline = true;
            this.SimpleBindingURL.Name = "SimpleBindingURL";
            this.SimpleBindingURL.ReadOnly = true;
            this.SimpleBindingURL.Size = new System.Drawing.Size(269, 103);
            this.SimpleBindingURL.TabIndex = 36;
            this.SimpleBindingURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(805, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 104);
            this.label3.TabIndex = 44;
            this.label3.Text = "JSON";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(803, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 103);
            this.label4.TabIndex = 43;
            this.label4.Text = "Urlencoded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayJSON
            // 
            this.ModelBindingArrayJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayJSON.Location = new System.Drawing.Point(928, 245);
            this.ModelBindingArrayJSON.Multiline = true;
            this.ModelBindingArrayJSON.Name = "ModelBindingArrayJSON";
            this.ModelBindingArrayJSON.ReadOnly = true;
            this.ModelBindingArrayJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindingArrayJSON.TabIndex = 42;
            this.ModelBindingArrayJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayURL
            // 
            this.ModelBindingArrayURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayURL.Location = new System.Drawing.Point(928, 136);
            this.ModelBindingArrayURL.Multiline = true;
            this.ModelBindingArrayURL.Name = "ModelBindingArrayURL";
            this.ModelBindingArrayURL.ReadOnly = true;
            this.ModelBindingArrayURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindingArrayURL.TabIndex = 41;
            this.ModelBindingArrayURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(803, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 104);
            this.label5.TabIndex = 48;
            this.label5.Text = "JSON";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(803, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 103);
            this.label6.TabIndex = 47;
            this.label6.Text = "Urlencoded";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjJSON
            // 
            this.ModelBindingNestedObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjJSON.Location = new System.Drawing.Point(928, 471);
            this.ModelBindingNestedObjJSON.Multiline = true;
            this.ModelBindingNestedObjJSON.Name = "ModelBindingNestedObjJSON";
            this.ModelBindingNestedObjJSON.ReadOnly = true;
            this.ModelBindingNestedObjJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindingNestedObjJSON.TabIndex = 46;
            this.ModelBindingNestedObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjURL
            // 
            this.ModelBindingNestedObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjURL.Location = new System.Drawing.Point(928, 362);
            this.ModelBindingNestedObjURL.Multiline = true;
            this.ModelBindingNestedObjURL.Name = "ModelBindingNestedObjURL";
            this.ModelBindingNestedObjURL.ReadOnly = true;
            this.ModelBindingNestedObjURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindingNestedObjURL.TabIndex = 45;
            this.ModelBindingNestedObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(803, 688);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 97);
            this.label7.TabIndex = 52;
            this.label7.Text = "JSON";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(803, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 97);
            this.label8.TabIndex = 51;
            this.label8.Text = "Urlencoded";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjJSON
            // 
            this.ModelBindingArrayNestedObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjJSON.Location = new System.Drawing.Point(928, 688);
            this.ModelBindingArrayNestedObjJSON.Multiline = true;
            this.ModelBindingArrayNestedObjJSON.Name = "ModelBindingArrayNestedObjJSON";
            this.ModelBindingArrayNestedObjJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjJSON.Size = new System.Drawing.Size(269, 97);
            this.ModelBindingArrayNestedObjJSON.TabIndex = 50;
            this.ModelBindingArrayNestedObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjURL
            // 
            this.ModelBindingArrayNestedObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjURL.Location = new System.Drawing.Point(928, 585);
            this.ModelBindingArrayNestedObjURL.Multiline = true;
            this.ModelBindingArrayNestedObjURL.Name = "ModelBindingArrayNestedObjURL";
            this.ModelBindingArrayNestedObjURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjURL.Size = new System.Drawing.Size(269, 97);
            this.ModelBindingArrayNestedObjURL.TabIndex = 49;
            this.ModelBindingArrayNestedObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(205, 688);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 97);
            this.label9.TabIndex = 56;
            this.label9.Text = "JSON";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(205, 585);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 97);
            this.label10.TabIndex = 55;
            this.label10.Text = "Urlencoded";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindArrayJSON
            // 
            this.SimpleModelBindArrayJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayJSON.Location = new System.Drawing.Point(328, 688);
            this.SimpleModelBindArrayJSON.Multiline = true;
            this.SimpleModelBindArrayJSON.Name = "SimpleModelBindArrayJSON";
            this.SimpleModelBindArrayJSON.ReadOnly = true;
            this.SimpleModelBindArrayJSON.Size = new System.Drawing.Size(269, 97);
            this.SimpleModelBindArrayJSON.TabIndex = 54;
            this.SimpleModelBindArrayJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayURL
            // 
            this.SimpleModelBindArrayURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayURL.Location = new System.Drawing.Point(328, 585);
            this.SimpleModelBindArrayURL.Multiline = true;
            this.SimpleModelBindArrayURL.Name = "SimpleModelBindArrayURL";
            this.SimpleModelBindArrayURL.ReadOnly = true;
            this.SimpleModelBindArrayURL.Size = new System.Drawing.Size(269, 97);
            this.SimpleModelBindArrayURL.TabIndex = 53;
            this.SimpleModelBindArrayURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(1224, 808);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SimpleModelBindArrayJSON);
            this.Controls.Add(this.SimpleModelBindArrayURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModelBindingArrayNestedObjJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModelBindingNestedObjJSON);
            this.Controls.Add(this.ModelBindingNestedObjURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBindingArrayJSON);
            this.Controls.Add(this.ModelBindingArrayURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urlencoded);
            this.Controls.Add(this.SimpleBindingJSON);
            this.Controls.Add(this.SimpleBindingTItle);
            this.Controls.Add(this.SimpleBindingURL);
            this.Controls.Add(this.JSON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelBindObjJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjTitle);
            this.Controls.Add(this.SimpleModelBindArrayTitle);
            this.Controls.Add(this.ModelBindingNestedObjTitle);
            this.Controls.Add(this.ModelBindingArrayTitle);
            this.Controls.Add(this.ModelBindObjTitle);
            this.Controls.Add(this.ModelBindObjURL);
            this.Controls.Add(this.AgeFour);
            this.Controls.Add(this.NameFour);
            this.Controls.Add(this.AgeThr);
            this.Controls.Add(this.NameThr);
            this.Controls.Add(this.AgeTwo);
            this.Controls.Add(this.NameTwo);
            this.Controls.Add(this.AgeOne);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameOne);
            this.Controls.Add(this.button1);
            this.Name = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ForFunc DoFunc = new ForFunc();
            WebClientHandle WebClientFunc = new WebClientHandle();
            string[] NameInput = { NameOne.Text, NameTwo.Text, NameThr.Text, NameFour.Text };
            string[] AgeInput = { AgeOne.Text, AgeTwo.Text, AgeThr.Text, AgeFour.Text };
            List<string> Name = new List<string>();
            List<string> Age = new List<string>();
            for (int i = 0; i < NameInput.Length; i++)
            {
                if (!string.IsNullOrEmpty(NameInput[i]) && !string.IsNullOrEmpty(AgeInput[i]))
                {
                    Name.Add(NameInput[i]);
                    Age.Add(AgeInput[i]);
                }
                else
                {
                    continue;
                }
            }


            ////SimpleBinding
            //SimpleBinding(DoFunc.CreateNewDic(Name, Age, 1), DoFunc);
            SimpleBinding(Name[0],Age[0], DoFunc, WebClientFunc);


            ////ModelBinObj
            //ModelBindObj(DoFunc.CreateNewDic(Name, Age, 1), DoFunc);
            ModelBindObj(Name[0], Age[0], DoFunc, WebClientFunc);


            ////SimpleModelBindArray
            //SimpleModelBindingArray(Name, Age, DoFunc);
            SimpleModelBindingArray(Name, Age, DoFunc, WebClientFunc);


            ////ModelBindingArray
            //ModelBindingArray(Name, Age, DoFunc);
            ModelBindingArray(Name, Age, DoFunc, WebClientFunc);

            //////ModelBindingNestedObj
            //ModelBindingNestedObj(Name, Age, DoFunc);
            ModelBindingNestedObj(Name, Age, DoFunc, WebClientFunc);


            //////ModelBindingArrayNestedObj
            //ModelBindingArrayNestedObj(Name, Age, DoFunc);
            ModelBindingArrayNestedObj(Name, Age, DoFunc, WebClientFunc);

        }

        private void SimpleBinding(string Name,string Age, ForFunc DoFunc,WebClientHandle WebClientFunc)
        {
            //try
            //{
            //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleBinding");
            //    SimpleBindingURL.Text =DoFunc.SendinUrlEncoded(formDataDic, BaseURL).GetAwaiter().GetResult();

            //    Human data = new Human();
            //    data.Name = formDataDic["Name"];
            //    data.Age = Int32.Parse(formDataDic["Age"]);
            //    SimpleBindingJSON.Text = DoFunc.SendinJSON(data, BaseURL).GetAwaiter().GetResult();
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}
            try
            {
                using(WebClient client=new WebClient())
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleBinding");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    string PostData= WebClientFunc.QueryString(Name, Age);
                    SimpleBindingURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    Human PostDataJSON = new Human() { Name = Name, Age = Int32.Parse(Age) };
                    SimpleBindingJSON.Text = client.UploadString(BaseURL, JsonConvert.SerializeObject(PostDataJSON));
                }
            
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindObj(string Name,string Age, ForFunc DoFunc,WebClientHandle WebClientFunc)
        {
            //try
            //{
            //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindObj");
            //    ModelBindObjURL.Text = DoFunc.SendinUrlEncoded(formDataDic, BaseURL).GetAwaiter().GetResult(); ;

            //    Human data = new Human();
            //    data.Name = formDataDic["Name"];
            //    data.Age = Int32.Parse(formDataDic["Age"]);
            //    ModelBindObjJSON.Text = DoFunc.SendinJSON(data, BaseURL).GetAwaiter().GetResult(); ;
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}
            try
            {
                using (WebClient client = new WebClient())
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindObj");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    string PostData = WebClientFunc.QueryString(Name, Age);
                    ModelBindObjURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    Human PostDataJSON = new Human() { Name = Name, Age = Int32.Parse(Age) };
                    ModelBindObjJSON.Text = client.UploadString(BaseURL, JsonConvert.SerializeObject(PostDataJSON));
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }

        }

        // 待解
        private void SimpleModelBindingArray(List<string> Name, List<string> Age, ForFunc DoFunc,WebClientHandle WebClientFunc)
        {

            //try
            //{
            //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray?" + DoFunc.QueryString(Age));
            //    SimpleModelBindArrayURL.Text = DoFunc.SendinUrlEncoded(DoFunc.CreateNewDic(Name, Age, 2), BaseURL).GetAwaiter().GetResult();


            //    SimpleModelBindArrayJSON.Text = DoFunc.SendinJSON(Name, BaseURL).GetAwaiter().GetResult();
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}

            try
            {
                using (WebClient client = new WebClient())
                {
                    string PostData = WebClientFunc.QueryStringComplex(Name, Age,"SimpleModelBindingArray");
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray?"+PostData);
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    SimpleModelBindArrayURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    dynamic Data = new ExpandoObject();
                    Data.Name = Name;
                    Data.Age = Age;
                    SimpleModelBindArrayJSON.Text = client.UploadString(BaseURL, JsonConvert.SerializeObject(Data));
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingArray(List<string> Name, List<string> Age, ForFunc DoFunc,WebClientHandle WebClientFunc)
        {
            //try
            //{
            //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArray");
            //    List<Human> DataList = new List<Human>();
            //    for (int i = 0; i < Name.Count; i++)
            //    {
            //        Human Data = new Human();
            //        Data.Name = Name[i];
            //        Data.Age = Int32.Parse(Age[i]);
            //        DataList.Add(Data);
            //    };
            //    Human DataE = new Human();
            //    DataE.Name = Name[0];
            //    DataE.Age =Int32.Parse(Age[0]);
            //    var content = new Dictionary<string, string>
            //    {
            //        {"", JsonConvert.SerializeObject(DataE)}
            //    };

            //    ModelBindingArrayURL.Text = DoFunc.PosttoBack(new FormUrlEncodedContent(content), BaseURL).GetAwaiter().GetResult();
            //    //ModelBindingArrayURL.Text = await DoFunc.SendinUrlEncoded(TEST, BaseURL);
            //    //ModelBindingArrayJSON.Text = await DoFunc.SendinJSON(DataList, BaseURL);

            //    //DoFunc.QueryString(Name, Age);

            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}

            try
            {
                using (WebClient client = new WebClient())
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArray");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    string PostData = WebClientFunc.QueryStringComplex(Name, Age,"ModelBindingArray");
                    ModelBindingArrayURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    string PostDataJSON = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingArrayJSON");
                    ModelBindingArrayJSON.Text = client.UploadString(BaseURL, PostDataJSON);
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingNestedObj(List<string> Name, List<string> Age,ForFunc DoFunc, WebClientHandle WebClientFunc)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        Person DataList = new Person();
            //        List<Person> Data = new List<Person>();
            //        for (int i = 0; i < Name.Count; i++)
            //        {
            //            Person Friends = new Person();
            //            Friends.Name = Name[i];
            //            Friends.Age = Int32.Parse(Age[i]);
            //            Data.Add(Friends);
            //            DataList.Friends = Data;
            //        }

            //        Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingNestedObj");
            //        ModelBindingNestedObjJSON.Text = DoFunc.SendinJSON(DataList, BaseURL).GetAwaiter().GetResult();
            //    }
            //    catch (Exception error)
            //    {
            //        Console.WriteLine("{0}", error.Message);
            //    }
            //}
            using (WebClient client = new WebClient())
            {
                try
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingNestedObj");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    string PostData = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingNestedObj");
                    ModelBindingNestedObjURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    string PostDataJSON = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingNestedObjJSON");
                    ModelBindingNestedObjJSON.Text = client.UploadString(BaseURL, PostDataJSON);
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
        }

        private void ModelBindingArrayNestedObj(List<string> Name, List<string> Age,ForFunc DoFunc, WebClientHandle WebClientFunc)
        {
            //    try
            //    {
            //        List<Person> DataListA = new List<Person>();
            //        List<Person> DataListF = new List<Person>();
            //        Person Data = new Person();
            //        for (int i = 0; i < Name.Count; i++)
            //        {
            //            Person Friends = new Person();
            //            Friends.Name = Name[i];
            //            Friends.Age = Int32.Parse(Age[i]);
            //            DataListF.Add(Friends);
            //            Data.Friends = DataListF;
            //        }
            //        DataListA.Add(Data);
            //        Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArrayNestedObj");
            //        ModelBindingArrayNestedObjJSON.Text = DoFunc.SendinJSON(DataListA, BaseURL).GetAwaiter().GetResult();
            //}
            //    catch (Exception error)
            //    {
            //        Console.WriteLine("{0}", error.Message);
            //    }

            try
            {
                using (WebClient client = new WebClient())
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArrayNestedObj");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    string PostData = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingArrayNestedObj");
                    ModelBindingArrayNestedObjURL.Text = client.UploadString(BaseURL, PostData);

                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    string PostDataJSON = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingArrayNestedObjJSON");
                    ModelBindingArrayNestedObjJSON.Text = client.UploadString(BaseURL, PostDataJSON);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }



        private void WinForm_Load_1(object sender, EventArgs e)
        {

        }

        private void NameOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
