﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;

namespace AppCentralizacionCoomeva.Module.Utilidades
{
    public class Genericos
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public List<string> ConvertirExcel(string archivo)
        {
            #region Carga el archivo Excel
            DataSet result = new DataSet();
            try
            {
                #region Leer Excel
                if (archivo.EndsWith(".xlsx"))
                {
                    //Reading from a binary Excel file(format; .xlsx)
                    FileStream stream = File.Open(archivo, FileMode.Open, FileAccess.Read);
                    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    result = excelReader.AsDataSet();
                    excelReader.Close();
                }

                if (archivo.EndsWith(".xls"))
                {
                    //Reading from a binary Excel file('97-2003 format; .xls)
                    FileStream stream = File.Open(archivo, FileMode.Open, FileAccess.Read);
                    IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    result = excelReader.AsDataSet();
                    excelReader.Close();
                }

                #endregion

                #region Pasar Excel a Plano
                List<string> datosExcel = new List<string>();
                int numHoja = Convert.ToInt32(0);
                string a = "";

                for (int j = 0; j < result.Tables[numHoja].Rows.Count; j++)
                {
                    for (int i = 0; i < result.Tables[numHoja].Columns.Count; i++)
                    {
                        if (result.Tables[numHoja].Rows[j][i].ToString() != "")
                        {
                            a += result.Tables[numHoja].Rows[j][i].ToString().Replace("\n", " ").Trim();
                        }
                        else
                        {
                            a += " ";
                        }

                        if (i < (result.Tables[numHoja].Columns.Count + 1))
                        {
                            a += "|";
                        }
                    }

                    if (j != 0)
                    {
                        datosExcel.Add(a);
                    }

                    a = "";

                }
                #endregion

                return datosExcel;
            }
            catch (Exception mens)
            {
                throw new Exception("Error: " + mens.Message);
            }
            #endregion
        }

    }
}
