using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using System.Windows.Forms;

namespace Reconstruct.negocio
{
    class criaJson
    {
        public char Chr(int codigo)
        {
            return (char)codigo;

        }

    public string converteDataTabelParaJSON(DataTable dtb)
        {
            try
            {
                //define um array de strings
                string[] jsonArray = new string[dtb.Columns.Count];
                string headString = string.Empty;
                
                //percorre as colunas
                for (int i = 0; i < dtb.Columns.Count; i++) {
                    jsonArray[i] = dtb.Columns[i].Caption; // Array para todas as colunas
                    headString += "'" + jsonArray[i] + "' : '" + jsonArray[i] + i.ToString() + "%" + "',";

                }

                headString = headString.Substring(0, headString.Length - 1);
                
                //define um stringbuilder
                StringBuilder sb = new StringBuilder();
                sb.Append("{ "+ Chr(34)+"reconstrucoes" + Chr(34) +":[ \n");

                if (dtb.Rows.Count > 0){

                    for (int i = 0; i < dtb.Rows.Count ; i++){
                        string tempString = headString;

                        


                        sb.Append("{");

                        
                        // pega cada valor do  datatable
                        for (int j = 0; j < dtb.Columns.Count; j++){

                            tempString = tempString.Replace(dtb.Columns[j] + j.ToString() + "%", dtb.Rows[i][j].ToString());
                            

                        }

                        if (i == dtb.Rows.Count - 1)
                        {
                            sb.Append(tempString + "} \n");
                        } else
                        {
                            sb.Append(tempString + "}, \n");

                        }

                    }

                    

                }
                else
                {
                    string tempString = headString;
                    sb.Append("{");
                    for (int j = 0; j < dtb.Columns.Count; j++)
                    {
                        tempString = tempString.Replace(dtb.Columns[j] + j.ToString() + "%", "-");
                    }
                    sb.Append(tempString + "},");
                }
                sb = new StringBuilder(sb.ToString().Substring(0, sb.ToString().Length - 1));
                sb.Append("\n ]}");


                ///As barras dão problema na hora de ler as informações
                sb.Replace("\\", "/");
                return sb.ToString(); // saida json formatada
                

            }


            catch (Exception ex)
            {
                throw ex;
            }
        }









    }
}
