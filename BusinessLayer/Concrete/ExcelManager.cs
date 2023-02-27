using BusinessLayer.Abstract;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> list) where T : class
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Report");
            workSheet.Cells["A1"].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Light1);

            return excel.GetAsByteArray();
        }
    }
}
