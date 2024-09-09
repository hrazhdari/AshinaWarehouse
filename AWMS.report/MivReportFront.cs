namespace AWMS.report
{
    public partial class MivReportFront : DevExpress.XtraReports.UI.XtraReport
    {
        public MivReportFront()
        {
            InitializeComponent();

            //// تغییر جهت صفحه به Landscape
            //this.Landscape = true;

            //// تنظیم سایز صفحه به A4 در حالت Landscape
            //this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;

            //// در صورت نیاز، مقادیر PageWidth و PageHeight را به صورت دستی تنظیم کنید
            //this.PageWidth = 2970; // عرض A4 در حالت Landscape
            //this.PageHeight = 2100; // ارتفاع A4 در حالت Landscape

            // ایجاد یک پارامتر به نام MivNumber
            //DevExpress.XtraReports.Parameters.Parameter param = new DevExpress.XtraReports.Parameters.Parameter();
            //param.Name = "MivNumber";
            //param.Type = typeof(string);
            //param.Visible = true; // اگر می‌خواهید پارامتر در گزارش قابل مشاهده باشد
            //this.Parameters.Add(param);

            // فرض کنید شما یک Label به نام lblMivNumber در گزارش دارید
            //this.xrLabel2.DataBindings.Add("Text", null, "MivNumber");
            // در داخل سازنده گزارش (constructor)
            DevExpress.XtraReports.UI.CalculatedField rowNumberField = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalculatedFields.Add(rowNumberField);

            rowNumberField.Name = "RowNumber";
            rowNumberField.Expression = "Iif(True, [DataSource.CurrentRowIndex] + 1, 0)";

            // مثال برای یک Table
            this.RowNumber.DataBindings.Add("Text", null, "RowNumber");

            this.mivlabel.DataBindings.Add("Text", null, "RequestNO");
            this.companylabel.DataBindings.Add("Text", null, "CompanyName");
            this.mrclabel.DataBindings.Add("Text", null, "MRCNO");
            this.datelabel.DataBindings.Add("Text", null, "ReqDate", "{0:yyyy/MM/dd}");
            this.pllabel.DataBindings.Add("Text", null, "PLName");
            this.pklabel.DataBindings.Add("Text", null, "PK");
            this.itemlabel.DataBindings.Add("Text", null, "ItemOfPk");
            this.taglabel.DataBindings.Add("Text", null, "Tag");
            this.descriptionlabel.DataBindings.Add("Text", null, "Description");
            this.unitlabel.DataBindings.Add("Text", null, "UnitName");
            this.remarklabel.DataBindings.Add("Text", null, "Remark");
            this.ReqQtyList.DataBindings.Add("Text", null, "ReqMivQty");

            //this.DescriptionRich.DataBindings.Add("Text", null, "IssuedBy");

        }
    }
}
