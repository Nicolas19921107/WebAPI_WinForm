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
            this.ModelBindObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjTitle = new System.Windows.Forms.Label();
            this.SimpleModelBindArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Urlencoded = new System.Windows.Forms.Label();
            this.SimpleBindingHttpClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingTItle = new System.Windows.Forms.Label();
            this.SimpleBindingWebClientURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingHttpClientURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingRestCSharpURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebApiContribURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ModelBindingObjWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebClientURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ModelBindingArrayWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebClientURL = new System.Windows.Forms.TextBox();
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
            // ModelBindObjTitle
            // 
            this.ModelBindObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindObjTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjTitle.Location = new System.Drawing.Point(14, 376);
            this.ModelBindObjTitle.Name = "ModelBindObjTitle";
            this.ModelBindObjTitle.Size = new System.Drawing.Size(185, 50);
            this.ModelBindObjTitle.TabIndex = 24;
            this.ModelBindObjTitle.Text = "ModelBindingObj( HttpClient )";
            this.ModelBindObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayTitle
            // 
            this.ModelBindingArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayTitle.Location = new System.Drawing.Point(829, 137);
            this.ModelBindingArrayTitle.Name = "ModelBindingArrayTitle";
            this.ModelBindingArrayTitle.Size = new System.Drawing.Size(185, 48);
            this.ModelBindingArrayTitle.TabIndex = 26;
            this.ModelBindingArrayTitle.Text = "ModelBindingArray( HttpClient )";
            this.ModelBindingArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjTitle
            // 
            this.ModelBindingNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjTitle.Location = new System.Drawing.Point(1538, 392);
            this.ModelBindingNestedObjTitle.Name = "ModelBindingNestedObjTitle";
            this.ModelBindingNestedObjTitle.Size = new System.Drawing.Size(185, 212);
            this.ModelBindingNestedObjTitle.TabIndex = 28;
            this.ModelBindingNestedObjTitle.Text = "ModelBindingNestedObj";
            this.ModelBindingNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindArrayTitle
            // 
            this.SimpleModelBindArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.SimpleModelBindArrayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayTitle.Location = new System.Drawing.Point(14, 606);
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
            this.ModelBindingArrayNestedObjTitle.Location = new System.Drawing.Point(1538, 615);
            this.ModelBindingArrayNestedObjTitle.Name = "ModelBindingArrayNestedObjTitle";
            this.ModelBindingArrayNestedObjTitle.Size = new System.Drawing.Size(185, 202);
            this.ModelBindingArrayNestedObjTitle.TabIndex = 32;
            this.ModelBindingArrayNestedObjTitle.Text = "ModelBindingArrayNestedObj";
            this.ModelBindingArrayNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(516, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 669);
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
            this.Urlencoded.Size = new System.Drawing.Size(119, 670);
            this.Urlencoded.TabIndex = 39;
            this.Urlencoded.Text = "Urlencoded";
            this.Urlencoded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingHttpClientJSON
            // 
            this.SimpleBindingHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingHttpClientJSON.Location = new System.Drawing.Point(641, 136);
            this.SimpleBindingHttpClientJSON.Multiline = true;
            this.SimpleBindingHttpClientJSON.Name = "SimpleBindingHttpClientJSON";
            this.SimpleBindingHttpClientJSON.ReadOnly = true;
            this.SimpleBindingHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingHttpClientJSON.TabIndex = 38;
            this.SimpleBindingHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingTItle
            // 
            this.SimpleBindingTItle.BackColor = System.Drawing.Color.Orange;
            this.SimpleBindingTItle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingTItle.Location = new System.Drawing.Point(16, 137);
            this.SimpleBindingTItle.Name = "SimpleBindingTItle";
            this.SimpleBindingTItle.Size = new System.Drawing.Size(181, 50);
            this.SimpleBindingTItle.TabIndex = 37;
            this.SimpleBindingTItle.Text = "SimpleBinding( HttpClient )";
            this.SimpleBindingTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingWebClientURL
            // 
            this.SimpleBindingWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebClientURL.Location = new System.Drawing.Point(328, 191);
            this.SimpleBindingWebClientURL.Multiline = true;
            this.SimpleBindingWebClientURL.Name = "SimpleBindingWebClientURL";
            this.SimpleBindingWebClientURL.ReadOnly = true;
            this.SimpleBindingWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingWebClientURL.TabIndex = 36;
            this.SimpleBindingWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingHttpClientURL
            // 
            this.SimpleBindingHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingHttpClientURL.Location = new System.Drawing.Point(328, 136);
            this.SimpleBindingHttpClientURL.Multiline = true;
            this.SimpleBindingHttpClientURL.Name = "SimpleBindingHttpClientURL";
            this.SimpleBindingHttpClientURL.ReadOnly = true;
            this.SimpleBindingHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingHttpClientURL.TabIndex = 57;
            this.SimpleBindingHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingRestCSharpURL
            // 
            this.SimpleBindingRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingRestCSharpURL.Location = new System.Drawing.Point(328, 245);
            this.SimpleBindingRestCSharpURL.Multiline = true;
            this.SimpleBindingRestCSharpURL.Name = "SimpleBindingRestCSharpURL";
            this.SimpleBindingRestCSharpURL.ReadOnly = true;
            this.SimpleBindingRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingRestCSharpURL.TabIndex = 58;
            this.SimpleBindingRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebApiContribURL
            // 
            this.SimpleBindingWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebApiContribURL.Location = new System.Drawing.Point(328, 299);
            this.SimpleBindingWebApiContribURL.Multiline = true;
            this.SimpleBindingWebApiContribURL.Name = "SimpleBindingWebApiContribURL";
            this.SimpleBindingWebApiContribURL.ReadOnly = true;
            this.SimpleBindingWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingWebApiContribURL.TabIndex = 59;
            this.SimpleBindingWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebClientJSON
            // 
            this.SimpleBindingWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebClientJSON.Location = new System.Drawing.Point(641, 189);
            this.SimpleBindingWebClientJSON.Multiline = true;
            this.SimpleBindingWebClientJSON.Name = "SimpleBindingWebClientJSON";
            this.SimpleBindingWebClientJSON.ReadOnly = true;
            this.SimpleBindingWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingWebClientJSON.TabIndex = 60;
            this.SimpleBindingWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingRestCSharpJSON
            // 
            this.SimpleBindingRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingRestCSharpJSON.Location = new System.Drawing.Point(641, 245);
            this.SimpleBindingRestCSharpJSON.Multiline = true;
            this.SimpleBindingRestCSharpJSON.Name = "SimpleBindingRestCSharpJSON";
            this.SimpleBindingRestCSharpJSON.ReadOnly = true;
            this.SimpleBindingRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingRestCSharpJSON.TabIndex = 61;
            this.SimpleBindingRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebApiContribJSON
            // 
            this.SimpleBindingWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebApiContribJSON.Location = new System.Drawing.Point(641, 299);
            this.SimpleBindingWebApiContribJSON.Multiline = true;
            this.SimpleBindingWebApiContribJSON.Name = "SimpleBindingWebApiContribJSON";
            this.SimpleBindingWebApiContribJSON.ReadOnly = true;
            this.SimpleBindingWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingWebApiContribJSON.TabIndex = 62;
            this.SimpleBindingWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 50);
            this.label2.TabIndex = 63;
            this.label2.Text = "SimpleBinding( WebClient )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 50);
            this.label9.TabIndex = 64;
            this.label9.Text = "SimpleBinding( RestCSharp  )";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 50);
            this.label10.TabIndex = 65;
            this.label10.Text = "SimpleBinding(  WebApiContrib  )";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Orange;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 50);
            this.label11.TabIndex = 66;
            this.label11.Text = "ModelBindingObj( WebClient )";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Orange;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 50);
            this.label12.TabIndex = 67;
            this.label12.Text = "ModelBindingObj( RestCSharp )";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Orange;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 50);
            this.label13.TabIndex = 68;
            this.label13.Text = "ModelBindingObj( WebApiContrib )";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingObjWebApiContribJSON
            // 
            this.ModelBindingObjWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebApiContribJSON.Location = new System.Drawing.Point(641, 539);
            this.ModelBindingObjWebApiContribJSON.Multiline = true;
            this.ModelBindingObjWebApiContribJSON.Name = "ModelBindingObjWebApiContribJSON";
            this.ModelBindingObjWebApiContribJSON.ReadOnly = true;
            this.ModelBindingObjWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjWebApiContribJSON.TabIndex = 76;
            this.ModelBindingObjWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjRestCSharpJSON
            // 
            this.ModelBindingObjRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjRestCSharpJSON.Location = new System.Drawing.Point(641, 485);
            this.ModelBindingObjRestCSharpJSON.Multiline = true;
            this.ModelBindingObjRestCSharpJSON.Name = "ModelBindingObjRestCSharpJSON";
            this.ModelBindingObjRestCSharpJSON.ReadOnly = true;
            this.ModelBindingObjRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjRestCSharpJSON.TabIndex = 75;
            this.ModelBindingObjRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebClientJSON
            // 
            this.ModelBindingObjWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebClientJSON.Location = new System.Drawing.Point(641, 429);
            this.ModelBindingObjWebClientJSON.Multiline = true;
            this.ModelBindingObjWebClientJSON.Name = "ModelBindingObjWebClientJSON";
            this.ModelBindingObjWebClientJSON.ReadOnly = true;
            this.ModelBindingObjWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjWebClientJSON.TabIndex = 74;
            this.ModelBindingObjWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebApiContribURL
            // 
            this.ModelBindingObjWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebApiContribURL.Location = new System.Drawing.Point(328, 539);
            this.ModelBindingObjWebApiContribURL.Multiline = true;
            this.ModelBindingObjWebApiContribURL.Name = "ModelBindingObjWebApiContribURL";
            this.ModelBindingObjWebApiContribURL.ReadOnly = true;
            this.ModelBindingObjWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjWebApiContribURL.TabIndex = 73;
            this.ModelBindingObjWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjRestCSharpURL
            // 
            this.ModelBindingObjRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjRestCSharpURL.Location = new System.Drawing.Point(328, 485);
            this.ModelBindingObjRestCSharpURL.Multiline = true;
            this.ModelBindingObjRestCSharpURL.Name = "ModelBindingObjRestCSharpURL";
            this.ModelBindingObjRestCSharpURL.ReadOnly = true;
            this.ModelBindingObjRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjRestCSharpURL.TabIndex = 72;
            this.ModelBindingObjRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjHttpClientURL
            // 
            this.ModelBindingObjHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjHttpClientURL.Location = new System.Drawing.Point(328, 376);
            this.ModelBindingObjHttpClientURL.Multiline = true;
            this.ModelBindingObjHttpClientURL.Name = "ModelBindingObjHttpClientURL";
            this.ModelBindingObjHttpClientURL.ReadOnly = true;
            this.ModelBindingObjHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjHttpClientURL.TabIndex = 71;
            this.ModelBindingObjHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjHttpClientJSON
            // 
            this.ModelBindingObjHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjHttpClientJSON.Location = new System.Drawing.Point(641, 376);
            this.ModelBindingObjHttpClientJSON.Multiline = true;
            this.ModelBindingObjHttpClientJSON.Name = "ModelBindingObjHttpClientJSON";
            this.ModelBindingObjHttpClientJSON.ReadOnly = true;
            this.ModelBindingObjHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjHttpClientJSON.TabIndex = 70;
            this.ModelBindingObjHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebClientURL
            // 
            this.ModelBindingObjWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebClientURL.Location = new System.Drawing.Point(328, 431);
            this.ModelBindingObjWebClientURL.Multiline = true;
            this.ModelBindingObjWebClientURL.Name = "ModelBindingObjWebClientURL";
            this.ModelBindingObjWebClientURL.ReadOnly = true;
            this.ModelBindingObjWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjWebClientURL.TabIndex = 69;
            this.ModelBindingObjWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1333, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 669);
            this.label3.TabIndex = 78;
            this.label3.Text = "JSON";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1020, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 670);
            this.label4.TabIndex = 77;
            this.label4.Text = "Urlencoded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(829, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 48);
            this.label5.TabIndex = 79;
            this.label5.Text = "ModelBindingArray( WebClient )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(829, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 48);
            this.label6.TabIndex = 80;
            this.label6.Text = "ModelBindingArray( RestCSharp )";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(829, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 48);
            this.label7.TabIndex = 81;
            this.label7.Text = "ModelBindingArray( WebApiContrib )";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayWebApiContribJSON
            // 
            this.ModelBindingArrayWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebApiContribJSON.Location = new System.Drawing.Point(1458, 299);
            this.ModelBindingArrayWebApiContribJSON.Multiline = true;
            this.ModelBindingArrayWebApiContribJSON.Name = "ModelBindingArrayWebApiContribJSON";
            this.ModelBindingArrayWebApiContribJSON.ReadOnly = true;
            this.ModelBindingArrayWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayWebApiContribJSON.TabIndex = 89;
            this.ModelBindingArrayWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayRestCSharpJSON
            // 
            this.ModelBindingArrayRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayRestCSharpJSON.Location = new System.Drawing.Point(1458, 245);
            this.ModelBindingArrayRestCSharpJSON.Multiline = true;
            this.ModelBindingArrayRestCSharpJSON.Name = "ModelBindingArrayRestCSharpJSON";
            this.ModelBindingArrayRestCSharpJSON.ReadOnly = true;
            this.ModelBindingArrayRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayRestCSharpJSON.TabIndex = 88;
            this.ModelBindingArrayRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebClientJSON
            // 
            this.ModelBindingArrayWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebClientJSON.Location = new System.Drawing.Point(1458, 189);
            this.ModelBindingArrayWebClientJSON.Multiline = true;
            this.ModelBindingArrayWebClientJSON.Name = "ModelBindingArrayWebClientJSON";
            this.ModelBindingArrayWebClientJSON.ReadOnly = true;
            this.ModelBindingArrayWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayWebClientJSON.TabIndex = 87;
            this.ModelBindingArrayWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebApiContribURL
            // 
            this.ModelBindingArrayWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebApiContribURL.Location = new System.Drawing.Point(1145, 299);
            this.ModelBindingArrayWebApiContribURL.Multiline = true;
            this.ModelBindingArrayWebApiContribURL.Name = "ModelBindingArrayWebApiContribURL";
            this.ModelBindingArrayWebApiContribURL.ReadOnly = true;
            this.ModelBindingArrayWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayWebApiContribURL.TabIndex = 86;
            this.ModelBindingArrayWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayRestCSharpURL
            // 
            this.ModelBindingArrayRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayRestCSharpURL.Location = new System.Drawing.Point(1145, 245);
            this.ModelBindingArrayRestCSharpURL.Multiline = true;
            this.ModelBindingArrayRestCSharpURL.Name = "ModelBindingArrayRestCSharpURL";
            this.ModelBindingArrayRestCSharpURL.ReadOnly = true;
            this.ModelBindingArrayRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayRestCSharpURL.TabIndex = 85;
            this.ModelBindingArrayRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayHttpClientURL
            // 
            this.ModelBindingArrayHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayHttpClientURL.Location = new System.Drawing.Point(1145, 136);
            this.ModelBindingArrayHttpClientURL.Multiline = true;
            this.ModelBindingArrayHttpClientURL.Name = "ModelBindingArrayHttpClientURL";
            this.ModelBindingArrayHttpClientURL.ReadOnly = true;
            this.ModelBindingArrayHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayHttpClientURL.TabIndex = 84;
            this.ModelBindingArrayHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayHttpClientJSON
            // 
            this.ModelBindingArrayHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayHttpClientJSON.Location = new System.Drawing.Point(1458, 136);
            this.ModelBindingArrayHttpClientJSON.Multiline = true;
            this.ModelBindingArrayHttpClientJSON.Name = "ModelBindingArrayHttpClientJSON";
            this.ModelBindingArrayHttpClientJSON.ReadOnly = true;
            this.ModelBindingArrayHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayHttpClientJSON.TabIndex = 83;
            this.ModelBindingArrayHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebClientURL
            // 
            this.ModelBindingArrayWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebClientURL.Location = new System.Drawing.Point(1145, 191);
            this.ModelBindingArrayWebClientURL.Multiline = true;
            this.ModelBindingArrayWebClientURL.Name = "ModelBindingArrayWebClientURL";
            this.ModelBindingArrayWebClientURL.ReadOnly = true;
            this.ModelBindingArrayWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayWebClientURL.TabIndex = 82;
            this.ModelBindingArrayWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(1813, 852);
            this.Controls.Add(this.ModelBindingArrayWebApiContribJSON);
            this.Controls.Add(this.ModelBindingArrayRestCSharpJSON);
            this.Controls.Add(this.ModelBindingArrayWebClientJSON);
            this.Controls.Add(this.ModelBindingArrayWebApiContribURL);
            this.Controls.Add(this.ModelBindingArrayRestCSharpURL);
            this.Controls.Add(this.ModelBindingArrayHttpClientURL);
            this.Controls.Add(this.ModelBindingArrayHttpClientJSON);
            this.Controls.Add(this.ModelBindingArrayWebClientURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBindingObjWebApiContribJSON);
            this.Controls.Add(this.ModelBindingObjRestCSharpJSON);
            this.Controls.Add(this.ModelBindingObjWebClientJSON);
            this.Controls.Add(this.ModelBindingObjWebApiContribURL);
            this.Controls.Add(this.ModelBindingObjRestCSharpURL);
            this.Controls.Add(this.ModelBindingObjHttpClientURL);
            this.Controls.Add(this.ModelBindingObjHttpClientJSON);
            this.Controls.Add(this.ModelBindingObjWebClientURL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SimpleBindingWebApiContribJSON);
            this.Controls.Add(this.SimpleBindingRestCSharpJSON);
            this.Controls.Add(this.SimpleBindingWebClientJSON);
            this.Controls.Add(this.SimpleBindingWebApiContribURL);
            this.Controls.Add(this.SimpleBindingRestCSharpURL);
            this.Controls.Add(this.SimpleBindingHttpClientURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urlencoded);
            this.Controls.Add(this.SimpleBindingHttpClientJSON);
            this.Controls.Add(this.SimpleBindingTItle);
            this.Controls.Add(this.SimpleBindingWebClientURL);
            this.Controls.Add(this.ModelBindingArrayNestedObjTitle);
            this.Controls.Add(this.SimpleModelBindArrayTitle);
            this.Controls.Add(this.ModelBindingNestedObjTitle);
            this.Controls.Add(this.ModelBindingArrayTitle);
            this.Controls.Add(this.ModelBindObjTitle);
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
            HttpClientHandle DoFunc = new HttpClientHandle();
            WebClientHandle WebClientFunc = new WebClientHandle();
            RestSharpClient RestSharpFunc = new RestSharpClient();
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


            //SimpleBinding
            SimpleBinding(Name[0],Age[0], DoFunc, WebClientFunc,RestSharpFunc);


            //ModelBinObj
            ModelBindObj(Name[0], Age[0], DoFunc, WebClientFunc, RestSharpFunc);


            ////SimpleModelBindArray
            //SimpleModelBindingArray(Name, Age, DoFunc, WebClientFunc, RestSharpFunc);


            ////ModelBindingArray
            ModelBindingArray(Name, Age, DoFunc, WebClientFunc, RestSharpFunc);

            ////ModelBindingNestedObj
            //ModelBindingNestedObj(Name, Age, DoFunc, WebClientFunc, RestSharpFunc);


            ////ModelBindingArrayNestedObj
            //ModelBindingArrayNestedObj(Name, Age, DoFunc, WebClientFunc, RestSharpFunc);

        }

        private void SimpleBinding(string Name,string Age, HttpClientHandle HttpClientFunc,WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
        {
            try
            {
                
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleBinding");

                // HttpClient
                SimpleBindingHttpClientURL.Text = HttpClientFunc.CreateNewDic(Name, Age, BaseURL);
                SimpleBindingHttpClientJSON.Text = HttpClientFunc.SendinJSON(Name, Age, BaseURL);

                // RestCSharp
                SimpleBindingRestCSharpURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL);
                SimpleBindingRestCSharpJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL);

                // WebClient
                SimpleBindingWebClientURL.Text = WebClientFunc.PostData(Name, Age, "application/x-www-form-urlencoded", BaseURL);
                SimpleBindingWebClientJSON.Text = WebClientFunc.PostData(Name, Age, "application/json", BaseURL);


            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindObj(string Name,string Age, HttpClientHandle HttpClientFunc, WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
        {
            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindObj");

                // HttpClient
                ModelBindingObjHttpClientURL.Text = HttpClientFunc.CreateNewDic(Name, Age, BaseURL);
                ModelBindingObjHttpClientJSON.Text = HttpClientFunc.SendinJSON(Name, Age, BaseURL);

                // WebClient
                ModelBindingObjWebClientURL.Text = WebClientFunc.PostData(Name, Age, "application/x-www-form-urlencoded", BaseURL);
                ModelBindingObjWebClientJSON.Text = WebClientFunc.PostData(Name, Age, "application/json", BaseURL);

                // RestCSharp
                ModelBindingObjRestCSharpURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL);
                ModelBindingObjRestCSharpJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL);
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }

        }

        // 待解
        private void SimpleModelBindingArray(List<string> Name, List<string> Age, HttpClientHandle HttpClientFunc,WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
        {

            //try
            //{
            //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray?" + HttpClientFunc.QueryString(Age));
            //    SimpleModelBindArrayURL.Text = HttpClientFunc.SendinUrlEncoded(HttpClientFunc.CreateNewDic(Name, Age, 2), BaseURL).GetAwaiter().GetResult();


            //    SimpleModelBindArrayJSON.Text = HttpClientFunc.SendinJSON(Name, BaseURL).GetAwaiter().GetResult();
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}

            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray");
                //using (WebClient client = new WebClient())
                //{
                //    string PostData = WebClientFunc.QueryStringComplex(Name, Age, "SimpleModelBindingArray");
                //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray?" + PostData);
                //    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                //    SimpleModelBindArrayURL.Text = client.UploadString(BaseURL, PostData);

                //    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                //    dynamic Data = new ExpandoObject();
                //    Data.Name = Name;
                //    Data.Age = Age;
                //    SimpleModelBindArrayJSON.Text = client.UploadString(BaseURL, JsonConvert.SerializeObject(Data));
                //}


                // RestCSharp
                //SimpleModelBindArrayURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL, "SimpleModelBindingArray");
                //SimpleModelBindArrayJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL, "SimpleModelBindingArray");
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingArray(List<string> Name, List<string> Age, HttpClientHandle HttpClientFunc, WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
        {
            //try
            //{
            //    //Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArray");
            //    //List<Human> DataList = new List<Human>();
            //    //for (int i = 0; i < Name.Count; i++)
            //    //{
            //    //    Human Data = new Human();
            //    //    Data.Name = Name[i];
            //    //    Data.Age = Int32.Parse(Age[i]);
            //    //    DataList.Add(Data);
            //    //};
            //    //Human DataE = new Human();
            //    //DataE.Name = Name[0];
            //    //DataE.Age = Int32.Parse(Age[0]);
            //    //var content = new Dictionary<string, string>
            //    //{
            //    //    {"", JsonConvert.SerializeObject(DataE)}
            //    //};

            //    //ModelBindingArrayURL.Text = HttpClientFunc.PostURL(new FormUrlEncodedContent(content), BaseURL).GetAwaiter().GetResult();

            //    // RestCSharp
            //    //ModelBindingArrayURL.Text = await HttpClientFunc.SendinUrlEncoded(TEST, BaseURL);
            //    //ModelBindingArrayJSON.Text = await HttpClientFunc.SendinJSON(DataList, BaseURL);

            //    //HttpClientFunc.QueryString(Name, Age);

            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine("{0}", error.Message);
            //}

            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArray");

                // RestCSharp
                ModelBindingArrayHttpClientURL.Text = HttpClientFunc.CreateNewDic(Name, Age, BaseURL,"ModelBindingArray");
                ModelBindingArrayHttpClientJSON.Text = HttpClientFunc.CreateNewDic(Name, Age, BaseURL, "ModelBindingArrayJSON");

                // WebClient
                ModelBindingArrayWebClientURL.Text = WebClientFunc.PostData(Name, Age, BaseURL, "application/x-www-form-urlencoded", "ModelBindingArray");
                ModelBindingArrayWebClientJSON.Text = WebClientFunc.PostData(Name, Age, BaseURL, "application/json", "ModelBindingArrayJSON");

                // RestCSharp
                ModelBindingArrayRestCSharpURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL, "ModelBindingArray");
                ModelBindingArrayRestCSharpJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL, "ModelBindingArray");

            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingNestedObj(List<string> Name, List<string> Age,HttpClientHandle DoFunc, WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
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
            //        ModelBindingNestedObjJSON.Text = HttpClientFunc.SendinJSON(DataList, BaseURL).GetAwaiter().GetResult();
            //    }
            //    catch (Exception error)
            //    {
            //        Console.WriteLine("{0}", error.Message);
            //    }
            //}

                try
                {
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingNestedObj");

                    //using (WebClient client = new WebClient())
                    //{
                    //Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingNestedObj");
                    //client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    //string PostData = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingNestedObj");
                    //ModelBindingNestedObjURL.Text = client.UploadString(BaseURL, PostData);

                    //client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    //string PostDataJSON = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingNestedObjJSON");
                    //ModelBindingNestedObjJSON.Text = client.UploadString(BaseURL, PostDataJSON);

                    //}

                    // RestCSharp
                    //ModelBindingNestedObjURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL, "ModelBindingNestedObj");
                    //ModelBindingNestedObjJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL, "ModelBindingNestedObj");
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            
        }

        private void ModelBindingArrayNestedObj(List<string> Name, List<string> Age,HttpClientHandle DoFunc, WebClientHandle WebClientFunc, RestSharpClient RestSharpFunc)
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
            //        ModelBindingArrayNestedObjJSON.Text = HttpClientFunc.SendinJSON(DataListA, BaseURL).GetAwaiter().GetResult();
            //}
            //    catch (Exception error)
            //    {
            //        Console.WriteLine("{0}", error.Message);
            //    }

            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArrayNestedObj");
                //using (WebClient client = new WebClient())
                //{
                //    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArrayNestedObj");
                //    client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                //    string PostData = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingArrayNestedObj");
                //    ModelBindingArrayNestedObjURL.Text = client.UploadString(BaseURL, PostData);

                //    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                //    string PostDataJSON = WebClientFunc.QueryStringComplex(Name, Age, "ModelBindingArrayNestedObjJSON");
                //    ModelBindingArrayNestedObjJSON.Text = client.UploadString(BaseURL, PostDataJSON);
                //}

                // RestCSharp
                //ModelBindingArrayNestedObjURL.Text = RestSharpFunc.PostURL(Name, Age, BaseURL, "ModelBindingArrayNestedObj");
                //ModelBindingArrayNestedObjJSON.Text = RestSharpFunc.PostJSON(Name, Age, BaseURL, "ModelBindingArrayNestedObj");
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
