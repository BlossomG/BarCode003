using System;
using System.Drawing;
using System.IO;
using Seagull.BarTender.Print;
using System.Windows.Forms;

namespace BarCode003
{
  public class SeagullBC
  {
    public static void ShipBoxLabel( string strFile
                                   , int intCopies
                                   , string strPartNo
                                   , string strPartDesc
                                   , string strPO
                                   , string strJobOrder
                                   , string strCustomerName
                                   , string strQty
                                   , string strLastQty
                                   , string subApp
                                   , string strPtr = "" )
    {
      bool haveEnterpriseEdition = false;
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        Result retval;
        try
        {
          // Start the BarTender print engine.
          btEngine.Start();

          // Open a format.
          LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);
          btFormat.PrintSetup.EnablePrompting = false;

          // Change the name of the printer
          if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
          {
            btFormat.PrintSetup.PrinterName = strPtr;
          }

          // copies
          btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

          // PartNo
          btFormat.SubStrings["PartNo"].Value = strPartNo;

          // part Desc
          btFormat.SubStrings["PartDesc"].Value = strPartDesc;

          // lot
          btFormat.SubStrings["PoNumb"].Value = strPO;

          // job order 
          btFormat.SubStrings["JobOrder"].Value = strJobOrder;

          // customer name
          btFormat.SubStrings["CustName"].Value = strCustomerName;

          // qty
          btFormat.SubStrings["Qty"].Value = strQty;

          // last qty
          btFormat.SubStrings["QtyLast"].Value = strLastQty;

          // scrap
          int qty = 0;
          int lastqty = 0;
          if (int.TryParse(strQty, out qty) & int.TryParse(strLastQty, out lastqty))
          {
            btFormat.SubStrings["QtyScrap"].Value = (qty - lastqty).ToString();
          }
          else
          {
            btFormat.SubStrings["QtyScrap"].Value = "0";
          }

          FileInfo fi = new FileInfo(strFile);

          if (haveEnterpriseEdition)
          {
            Messages msgs = new Messages();
            Resolution dpi = new Resolution(600);
            string fileformat = string.Format("{0:yyyyMMddHHmmss}.jpeg", DateTime.Now);
            //PROTOTYPE
            //public Result ExportPrintPreviewToFile(string directory, string fileNameTemplate, ImageType imageType, ColorDepth colorDepth, Resolution resolution, Color backgroundColor, OverwriteOptions overwriteOptions, bool includeMargins, bool includeBorder, out Messages messages)
            retval = btFormat.ExportPrintPreviewToFile(fi.DirectoryName
                                                     , fileformat
                                                     , ImageType.JPEG
                                                     , Seagull.BarTender.Print.ColorDepth.Mono
                                                     , dpi
                                                     , Color.Transparent
                                                     , OverwriteOptions.Overwrite
                                                     , false
                                                     , false
                                                     , out msgs
                                                      );
          }
          else
          {
            // Print the format.
            retval = btFormat.Print();
          }

          string filename = fi.Name;
          ActionLog.LogDB(
              string.Format("Printed {0} copies of {1} for {2} sent to {3} on WO#{4}."
                          , intCopies
                          , filename
                          , strPartDesc
                          , strCustomerName
                          , strJobOrder)
             , subApp
          );
        }
        catch (Exception ex)
        {
          ErrorLog.HoustonWeHaveAProblem(ex);
          ActionLog.LogDB(ex.Message, subApp);
          MessageBox.Show(ex.Message);
        }
        finally
        {
          // Stop the BarTender print engine.
          btEngine.Stop();
        }
      }
    }

    public static void InspectionLabel( string strFile
                                      , int intCopies
                                      , string strCustLot
                                      , string strPartNumber
                                      , string strPartDesc
                                      , string subApp
                                      , string strPtr )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        Result retval;
        try
        {
          // Start the BarTender print engine.
          btEngine.Start();

          // Open a format.
          LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);
          btFormat.PrintSetup.EnablePrompting = false;

          // Change the name of the printer
          if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
          {
            btFormat.PrintSetup.PrinterName = strPtr;
          }

          // copies
          btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

          // PartNo
          btFormat.SubStrings["PartNo"].Value = strPartNumber;

          // part Desc
          btFormat.SubStrings["PartDesc"].Value = strPartDesc;

          // lot
          btFormat.SubStrings["Lot"].Value = strCustLot;

          //bin
          btFormat.SubStrings["BoxScan"].Value = strCustLot + " ^ " + strPartNumber;

          // Print the format.
          retval = btFormat.Print();

          string filename = (new FileInfo(strFile)).Name;
          ActionLog.LogDB(
              string.Format("Printed {0} copies of {1} for {2} {3} {4}."
                          , intCopies     //0
                          , filename      //1
                          , strCustLot    //2
                          , strPartNumber //3
                          , strPartDesc   //4
                            )
          , subApp
          );

        }
        catch (Exception ex)
        {
          ErrorLog.HoustonWeHaveAProblem(ex);
          ActionLog.LogDB(ex.Message, subApp);
          MessageBox.Show(ex.Message);
        }
        finally
        {
          // Stop the BarTender print engine.
          btEngine.Stop();
        }
      }
    }

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
                                       , string subApp
                                       , string strPtr )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        Result retval;
        try
        {
          // Start the BarTender print engine.
          btEngine.Start();
          // Open a format.
          LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);
          // Change the name of the printer
          if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
          {
            btFormat.PrintSetup.PrinterName = strPtr;
          }
          // copies
          btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;
          // PartNo
          btFormat.SubStrings["PartNo"].Value = strPartNo;
          // cust part no
          btFormat.SubStrings["CustPartNo"].Value = strCustPartNo;
          // Po Number
          btFormat.SubStrings["PoNumb"].Value = strPoNo;
          // Ship Number
          btFormat.SubStrings["ShipNo"].Value = strShipNo;
          // Lot No
          btFormat.SubStrings["LotNo"].Value = strLotNo;
          // Heat no
          btFormat.SubStrings["HeatNo"].Value = strHeatNo;
          // Qty
          btFormat.SubStrings["Qty"].Value = strQty;
          // Box No
          btFormat.SubStrings["BoxNo"].Value = strBoxNo;
          // KB
          btFormat.SubStrings["KB"].Value = strKB;

          // Print the format.
          retval = btFormat.Print();

          string filename = (new FileInfo(strFile)).Name;
          ActionLog.LogDB(
              string.Format("Printed {0} copies of {1} for {2} {3} {4} {5} {6} {7} {8} {9} {10}."
                          , intCopies     //0
                          , filename      //1
                          , strPartNo     //2
                          , strCustPartNo //3
                          , strPoNo       //4
                          , strShipNo     //5
                          , strLotNo      //6
                          , strHeatNo     //7
                          , strQty        //8
                          , strBoxNo      //9
                          , strKB         //10
                            )
          , subApp
          );
        }
        catch (Exception ex)
        {
          ErrorLog.HoustonWeHaveAProblem(ex);
          ActionLog.LogDB(ex.Message, subApp);
          MessageBox.Show(ex.Message);
        }
        finally
        {
          // Stop the BarTender print engine.
          btEngine.Stop();
        }
      }
    }

    public static void DLQLabel( string strFile
                               , int intCopies
                               , string strDie
                               , string strBox1
                               , string strBox2
                               , string strBox3
                               , string strLot1
                               , string strLot2
                               , string strLot3
                               , string strQty1
                               , string strQty2
                               , string strQty3
                               , string subApp
                               , string strPtr )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        do
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

            // die1
            if (strBox1.Trim().Length > 0)
            {
              btFormat.SubStrings["Die1"].Value = strDie;
            }
            else
            {
              btFormat.SubStrings["Die1"].Value = "";
            }

            // die2
            if (strBox2.Trim().Length > 0)
            {
              btFormat.SubStrings["Die2"].Value = strDie;
            }
            else
            {
              btFormat.SubStrings["Die2"].Value = "";
            }

            // die3
            if (strBox3.Trim().Length > 0)
            {
              btFormat.SubStrings["Die3"].Value = strDie;
            }
            else
            {
              btFormat.SubStrings["Die3"].Value = "";
            }

            // Box1
            btFormat.SubStrings["Box1"].Value = strBox1;

            // Box2
            btFormat.SubStrings["Box2"].Value = strBox2;

            // Box3
            btFormat.SubStrings["Box3"].Value = strBox3;


            // lot1
            btFormat.SubStrings["Lot1"].Value = strLot1;

            // lot2
            btFormat.SubStrings["Lot2"].Value = strLot2;

            // lot3
            btFormat.SubStrings["Lot3"].Value = strLot3;

            // qty1
            btFormat.SubStrings["Qty1"].Value = strQty1;

            // qty2
            btFormat.SubStrings["Qty2"].Value = strQty2;

            // qty3
            btFormat.SubStrings["Qty3"].Value = strQty3;

            // Print the format.
            retval = btFormat.Print();

            string filename = (new FileInfo(strFile)).Name;
            ActionLog.LogDB(
                string.Format("Printed {0} copies of {1} ({2}) for {3}-{6}-{9} {4}-{7}-{10} {5}-{8}-{11}."
                            , intCopies //0
                            , filename  //1
                            , strDie    //2
                            , strBox1   //3
                            , strBox2   //4
                            , strBox3   //5
                            , strLot1   //6
                            , strLot2   //7
                            , strLot3   //8
                            , strQty1   //9
                            , strQty2   //10
                            , strQty3   //11
                              )
            , subApp
            );
            break;
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            ActionLog.LogDB(ex.Message, subApp);
            MessageBox.Show(ex.Message);
          }
          finally
          {
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
        while (false);
      }
    }

    public static void Smith_NephewSwitzerland( string strFile
                                              , int intCopies
                                              , string strCustPartNo
                                              , string strCustPartDesc
                                              , string strLotNo
                                              , string strLotNo2
                                              , string strQty
                                              , string strQty2
                                              , string strBoxNo
                                              , string subApp
                                              , string strPtr )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        do
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;


            // Change the name of the printer
            // If strPtr.Trim.Length > 0 Then btFormat.PrintSetup.PrinterName = strPtr

            // //'PartNo
            // //btFormat.SubStrings["PartNo"].Value = strPartNo

            // cust part no
            btFormat.SubStrings["CustPartNo"].Value = strCustPartNo;

            // cust part desc
            btFormat.SubStrings["CustPartDesc"].Value = strCustPartDesc;

            // //'Po Number
            // //btFormat.SubStrings["PoNumb"].Value = strPoNo

            // //'Ship Number
            // //btFormat.SubStrings["ShipNo"].Value = strShipNo

            // Lot No
            btFormat.SubStrings["LotNo"].Value = strLotNo;

            // Lot No 2
            btFormat.SubStrings["LotNo2"].Value = strLotNo2;

            // //'Heat no
            // //btFormat.SubStrings["HeatNo"].Value = strHeatNo

            // Qty
            btFormat.SubStrings["Qty"].Value = strQty;

            // Qty2
            btFormat.SubStrings["Qty2"].Value = strQty2;

            // //'Box No
            btFormat.SubStrings["BoxNo"].Value = strBoxNo;

            // //'KB
            // //btFormat.SubStrings["KB"].Value = strKB

            // Change the name of the printer
            // If strPtr.Trim.Length > 0 Then btFormat.PrintSetup.PrinterName = strPtr

            // Print the format.
            retval = btFormat.Print();

            string filename = (new FileInfo(strFile)).Name;
            ActionLog.LogDB(
                string.Format("Printed {0} copies of {1} for {2} {3} {4} {5} {6} {7} {8}."
                            , intCopies       //0
                            , filename        //1
                            , strCustPartNo   //2
                            , strCustPartDesc //3
                            , strLotNo        //4
                            , strLotNo2       //5
                            , strQty          //6
                            , strQty2         //7
                            , strBoxNo        //8
                              )
            , subApp
            );
            break;
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            ActionLog.LogDB(ex.Message, subApp);
            MessageBox.Show(ex.Message);
          }
          finally
          {
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
        while (false);
      }
    }

    public static void MakeANote( string strDataOut, string strFile )
    {
      StreamWriter sw;
      string strTimeStamp = string.Format("hh:mm:ss yyyyMMdd - ", DateTime.Now);
      //string strFileName = strFile + "L" + string.Format(DateTime.Now, "yyyyMMdd") + ".txt";
      string strFileName = String.Format("{0}L{1:yyyyMMdd}.txt", strFile, DateTime.Now);
      do
      {
        try
        {
          if (!File.Exists(strFileName))
          {
            sw = File.CreateText(strFileName);
          }
          else
          {
            sw = File.AppendText(strFileName);
          } // If Not File.Exists(strFileName) Then

          sw.WriteLine(strTimeStamp + strDataOut);
          sw.Flush();
          sw.Close();
          break;
        }
        catch (Exception ex)
        {
          ErrorLog.HoustonWeHaveAProblem(ex);
        }
      }
      while (false);
    }

    public static void BCTEST( string strFile, int intCopies, string strHIBC_PartNO_PackLevel, string strExpDate, string strLotPlus, string strPtr = "" )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        do
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

            // primary Update
            btFormat.SubStrings["HIBC_ID"].Value = strHIBC_PartNO_PackLevel;

            // secondary
            btFormat.SubStrings["ExpDate"].Value = strExpDate;
            btFormat.SubStrings["LotPlus"].Value = strLotPlus;

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // Print the format.
            retval = btFormat.Print();

            // Stop the BarTender print engine.
            btEngine.Stop();
            break;
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
        while (false);
      }
    }

    public static void BCGenerate( string strFile, int intCopies, string strHIBC_PartNO_PackLevel, string strExpDate, string strLotPlus, string strLot, string strPtr = "" )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        do
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

            // primary Update
            btFormat.SubStrings["HIBC_ID"].Value = strHIBC_PartNO_PackLevel;

            // Lot
            btFormat.SubStrings["Lot"].Value = strLot;

            // printDate
            btFormat.SubStrings["PrintDate"].Value = DateTime.Now.ToString("yyyy-MM");

            // Expire Date Prime
            //Strings.Format(DateAndTime.DateAdd(DateInterval.Year, 5d, DateTime.Now), "yyyy-MM");
            btFormat.SubStrings["ExpPrintPrime"].Value = DateTime.Now.AddYears(5).ToString("yyyy-MM");

            // secondary
            btFormat.SubStrings["ExpDate"].Value = strExpDate;
            btFormat.SubStrings["LotPlus"].Value = strLotPlus;

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // Print the format.
            retval = btFormat.Print();

            // Stop the BarTender print engine.
            btEngine.Stop();
            break;
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
        while (false);
      }
    }

    public static void BCEndOFTheJob( string strFile, string strPtr = "" )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        //string strFound = FileSystem.Dir(strFile);
        if (File.Exists(strFile))
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = 1;

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // Print the format.
            retval = btFormat.Print();
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
          }
          finally
          {
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
      }
    }

    public static void PrimeLabel( string strFile, int intCopies, string strVer, string strPtr = "" )
    {
      // Initialize a new BarTender print engine.
      using (var btEngine = new Engine())
      {
        //Message messages = default;
        Result retval;
        do
        {
          try
          {
            // Start the BarTender print engine.
            btEngine.Start();

            // Open a format.
            LabelFormatDocument btFormat = btEngine.Documents.Open(strFile);

            // Change the name of the printer
            if (!string.IsNullOrWhiteSpace(strPtr.Trim()))
            {
              btFormat.PrintSetup.PrinterName = strPtr;
            }

            // copies
            btFormat.PrintSetup.IdenticalCopiesOfLabel = intCopies;

            // Change the name of the printer
            // If strPtr.Trim.Length > 0 Then btFormat.PrintSetup.PrinterName = strPtr

            // Version
            btFormat.SubStrings["Ver"].Value = strVer;

            // Print the format.
            retval = btFormat.Print();

            // Stop the BarTender print engine.
            btEngine.Stop();
            break;
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            // Stop the BarTender print engine.
            btEngine.Stop();
          }
        }
        while (false);
      }
    }
  }
}