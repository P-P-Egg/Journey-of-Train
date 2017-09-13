using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Excel;
using System.Data;
using System.IO;
using System.Xml;
using System.Linq;


public class exceldata : jiagou {
    public static string excelname ="dialoguedata.xls";
    public static string excelpath = "D:/unity project/Journey-of-Train/Assets/jiaer_test/dialoguedata.xls";
    public static string[] SheetNames = { "sheet1", "sheet2", "sheet3", "sheet4" };
    private void Start()
    {
        getDataset(excelpath);
    }
    public DataSet getDataset(string path)
    {
        FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(fs);
        DataSet ds = excelReader.AsDataSet();
        fs.Dispose();
        return ds;
    }
    public void Toxml(string xmlname, DataTable DT, string strAtt, string[] strelement)
    {
        if (DT != null)
        {
            if (DT.Rows.Count > 0)
            {
                if (!Directory.Exists(Application.streamingAssetsPath))
                {
                    Directory.CreateDirectory(Application.streamingAssetsPath);
                }
                string path = Application.streamingAssetsPath + "/" + xmlname + ".xml";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                XmlDocument writer = new XmlDocument();
                XmlElement x100 = writer.CreateElement(strAtt);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    XmlElement x10 = writer.CreateElement(strelement[0]);
                    for (int j = 0; j < strelement.Length - 1; j++)
                    {
                        XmlAttribute xa = writer.CreateAttribute(strelement[j]);
                        xa.Value = DT.Rows[i][j].ToString();
                        x10.Attributes.Append(xa);

                    }
                    x100.AppendChild(x10);
                }
                writer.AppendChild(x100);
                writer.Save(path);
            }
        }
    }
   
}
