using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Web;

namespace BarCode003
{
  public class SeagullBCSub
  {
    #region working vars
    protected Font printFont;
    protected StreamReader streamToPrint;
    #endregion

    protected SeagullBCSub()
    {
      this.printFont = new Font("Courier New", 10);
    }
    public SeagullBCSub( string strFile ) : this()
    {
      this.streamToPrint = new System.IO.StreamReader(strFile);
    }

    public static void ShipBoxLabel( string strFile //Name and location of btw file
                                   , int intCopies
                                   , string strPartNo
                                   , string strPartDesc
                                   , string strPO
                                   , string strJobOrder
                                   , string strCustomerName
                                   , string strQty
                                   , string strLastQty
                                   , string strPtr = "" )
    {
      string strEndQty = "0";
      StringBuilder sbwhere = new StringBuilder();
      sbwhere.AppendFormat("<orchidlogo> {0}", ChelseaDB.StreetAddress);
      sbwhere.AppendLine();
      sbwhere.AppendLine("-----------------------------------------------");
      sbwhere.AppendLine("Part # / Rev. and Name");
      sbwhere.AppendFormat(" {0} / ", strPartNo);
      sbwhere.AppendLine();
      sbwhere.AppendFormat(" {0}", strPartDesc);
      sbwhere.AppendLine();
      sbwhere.AppendLine("-----------------------+-----------------------");
      sbwhere.AppendLine("Customer PO #          |W.O #");
      int pospacerlen = 22 - strPO.Length;
      string pospacer = "";
      while (pospacerlen > 0)
      {
        pospacer += " ";
        pospacerlen--;
      }
      sbwhere.AppendFormat(" {0}{1}| {2}", strPO, pospacer, strJobOrder);
      sbwhere.AppendLine();
      sbwhere.AppendLine("-----------------------+-----------------------");
      sbwhere.AppendLine("                       |Date");
      sbwhere.AppendFormat("                       | {0}", DateTime.Now.ToString("dd-MMM-yyyy HH:mm"));
      sbwhere.AppendLine();
      sbwhere.AppendLine("-----------+-----------+-----------+-----------");
      sbwhere.AppendLine(" M2M       |           | M2M       | Actual");
      sbwhere.AppendLine(" Qty       |           | End Qty   | Count");
      int qtyspacerlen = 10 - strQty.Length;
      string qtyspacer = "";
      while (qtyspacerlen > 0)
      {
        qtyspacer += " ";
        qtyspacerlen--;
      }
      int eqtyspacerlen = 10 - strEndQty.Length;
      string eqtyspacer = "";
      while (eqtyspacerlen > 0)
      {
        eqtyspacer += " ";
        eqtyspacerlen--;
      }
      sbwhere.AppendFormat(" {0}{1}|           | {2}{3}| {4}"
                         , strQty, qtyspacer, strEndQty, eqtyspacer, strLastQty
                          );
      sbwhere.AppendLine();
      sbwhere.AppendLine("-----------+-----------+-----------+-----------");
      sbwhere.AppendLine(strCustomerName);
      sbwhere.AppendLine();

      SeagullBCSub.PrintIt(sbwhere.ToString(), intCopies);
    }

    public static void InspectionLabel( string strFile //Name and location of btw file
                                      , int intCopies
                                      , string strCustLot
                                      , string strPartNumber
                                      , string strPartDesc
                                      , string strPtr = "" )
    { }

    public static void StealthShipLabel( string strFile
                                       , int intCopies
                                       , string strPartNo
                                       , string strCustPartNo
                                       , string strPoNo
                                       , string strShipNo
                                       , string strLotNo
                                       , string strHeatNo
                                       , string strQty
                                       , string strBoxNo
                                       , string strKB
                                       , string strPtr = "" )
    {
      StringBuilder sb = new StringBuilder("<Orchid Logo>\r\n");
      sb.AppendFormat("Part Number: {0}\r\n", strPartNo);
      sb.AppendFormat("             ({0})\r\n", strCustPartNo);
      sb.AppendFormat("PO Number:   {0}\r\n", strPoNo);
      sb.AppendFormat("Shipper No:  {0}\r\n", strShipNo);
      sb.AppendFormat("Lot Number:  {0}\r\n", strLotNo);
      sb.AppendFormat("Heat Number: {0}\r\n", strHeatNo);
      sb.AppendFormat("Quantity:    {0}\r\n", strQty);
      sb.AppendFormat("Box Number:  {0}\r\n", strBoxNo);
      sb.AppendLine();
      sb.AppendLine();
      sb.AppendLine();
      sb.AppendFormat(
        string.IsNullOrWhiteSpace(strKB) ? "" : "             ({0})\r\n", strKB);
      sb.AppendLine();
      SeagullBCSub.PrintIt(sb.ToString(), intCopies);
    }

    public static void DLQLabel( string strFile, int intCopies, string strDie, string strBox1, string strBox2, string strBox3, string strLot1, string strLot2, string strLot3, string strQty1, string strQty2, string strQty3, string strPtr = "" )
    {
    }

    public static void PrintIt(string WhatToPrint, int intCopies)
    {
      string curdir = System.Reflection.Assembly.GetExecutingAssembly().Location;
      string where = string.Format("{0}{1}.txt", curdir, DateTime.Now.ToString("yyyyMMddHHmmss"));
      StreamWriter sw = new StreamWriter(where);
      sw.Write(WhatToPrint);
      sw.Flush();
      sw.Close();
      sw.Dispose();

      ActionLog.Log(String.Format("Attempting to print {0} copies of {1}", intCopies, where));
      for (int pc = 0; pc < intCopies; pc++)
      {
        SeagullBCSub theInstance = new SeagullBCSub(where);
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += new PrintPageEventHandler(theInstance.Event_PrintPage);
        pd.Print();
      }
      ActionLog.Log(String.Format("Printed {0} copies of {1}", intCopies, where));
      File.Delete(where);
    }
    private void Event_PrintPage( Object sender, PrintPageEventArgs ev )
    {
      int count = 0;
      float leftMargin = ev.MarginBounds.Left;
      float topMargin = ev.MarginBounds.Top;
      float yPos = 0;
      string line = "";

      // Calculate the number of lines per page.
      float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

      // Print each line of the file.
      while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
      {
        yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
        ev.Graphics.DrawString(line, printFont, Brushes.Black
                              ,leftMargin, yPos, new StringFormat());
        count++;
      }
      streamToPrint.Close();
      streamToPrint.Dispose();
    }
  }
}