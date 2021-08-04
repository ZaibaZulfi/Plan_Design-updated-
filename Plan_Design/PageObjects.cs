using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plan_Design.Steps
{
    class PageObjects
    {
        static string required_object;

        public static string Login_Screen(int which_object)
        {

            string user_id = "#txtLoginId"; // case 1 (cssselector for usser id)
            string password = "#txtPassword"; //case 2 (cssselector for password)
            string login_button = "#btnLogin"; // case 3 (cssselector for signIn button)
            string dashboard = "//h2[normalize-space()='Dashboard']"; // case 4 (xpath for Dashboard)
            string underwriting = "//span[@class='caret']/../../..//li[3]/a[text()='Underwriting ']";//case 5 (xpath of underwriting link)
            string manage_plandesign = "//a[normalize-space()='Manage Plan Design']";//case 6 (xpath for Manage Plan Design Link)
            string label_manage_PD = "#ctl00_cphMain_breadCrumb_lblHeading";//case 7 (xpath for Label-Manage PD)
            string Add_button_PD = "//a[@id='ctl00_cphMain_btnAddNewPlanDesign']";//case 8 (xpath for Button- Add New Plan Design)
            string Label_Account_Information = "#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_lbl90672c3e-abcf-4b99-be6c-f27953497580";//case 9 (cssselector for label Account Information on Add_PD)
            string FD1_Plan_Design_Name = "ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxb7fee7aa-ded9-4f00-a614-c205a704ca53";//case 10 (ID for plan design name)
            string button_Close = "//a[@id='ctl00_cphMain_lnkClose']";//Case 30(Xpath for Button- Add New Plan Design)
            string Export_to_Excel = "//a[@class='btn btn-info ']"; //case 31(Xpath for Button-Export_to_Excel)
            string Report = "//a[text()='Reports ']";//case 32 (xpath for report tab)
            string Label_MGU_Upload_Log = "//a[@id='ctl00_MenuControl_LinkButton12']";//case 33(xpath for MGU upload log)
            string MGU_Code = "//select[@class='form-control error-aon-blur']";//case 34(xpath for MGU_Code)
            string search = "//a[@class='btn btn-primary']";//case 35 (xpath for search)
            string Name_of_the_file = "(//td[@class='footable-visible'])[3]";//case 36 (id for Existing_MGU_upload)
            string download_file = "(//i[@class='fa fa-download fa-mx'])[1]";//(case 37 xpath for download))
            string view_detail = "(//i[@class='fa fa-arrow-circle-right fa-2x'])[1]";//(case 38 xpath for view details)
            string Export_to_Excel_MGU = "//a[@class='btn btn-info']";//(case 39 xpath for Export_to_excel)
            string Account_Name = "//a[@id='ctl00_cphMain_grdMGUUploads_ctl02_lnkButton']";//(case 40 xpath for Account_Name)
            string MGU_Upload_Log = "//a[text()='MGU Upload Log ']";//(case 41 xpath for MGU_Upload_Log)
            string search_Menue = "//a[text()='Search ']";//(case 42 xpath for search)
            string Document_Search = "//a[text()='Document Search']";//(case 43 xpath for document_search "ctl00_MenuControl_LinkButton13")
            string button_MGU_File_Upload = "//a[text()='MGU File Upload']";//(case 44 xpath for upload the file)
            string Enter_MGU_Code = "(//input[@class='form-control error-aon-blur'])[3]";//(case 45 xpath to enter MGU_Code)
            string button_upload_file = "//input[@class='btn btn-primary btn-xs btn-secondary-zr border-radius-none']";//(case 46 xpath for file_upload)
            string button_file_processing = "//a[@id='ctl00_cphMain_cntrlUpload_btnSubmit']";//(case 47 xpath for file processing)
            string button_FP_PopUp_Close = "//a[@id='ctl00_cphMain_cntrlUpload_messageBox_btnConfirm']";//(case 48 xpath for successfully file uploaded pop up message)
            string Bound_Business_File_Upload = "//span[text()='Bound Busines File Upload']";//(case 49 xpath for successfully file uploaded Assertion)
            string Error_File_Upload = "//span[text()='Error Bound Busines File Upload']";//(case 50 xpath for error in file upload- Assertion)
            string MGU_Download_Template = "//a[text()='Download Template']";//(case 51 xpath for download template)
            string State_Alaska = "(//ins[@class='iCheck-helper'])[2]";//(case 52 xpath for Alaska)
            string State_NewJersey = "(//ins[@class='iCheck-helper'])[45]";//(case 53 xpath for new jersey)
            string State_Vermont = "(//ins[@class='iCheck-helper'])[37]";//(case 54 xpath for Vermont   )
            string Effective_Date = "(//input[@class='form-control error-aon-blur'])[2]";//(case 55 xpath for effective date)
            string Effective_Date_Today = "(//th[text()='Today'])[1]";//(case 56 xpath for Effective Date--->CLICK "Today")
            string Expiration_Date = "(//i[@class='fa fa-calendar'])[2]";//(case 57 xpath for expiration date)
            string Expiration_Date_Month = "(//th[@class='datepicker-switch'])[1]";//(case 58 XPATH for Expiration Date--->CLICK May 2021)
            string Expiration_Date_Symbol = "(//th[@class='next'])[2]";//(case 59 XPATH for Expiration Date--->CLICK ">>")
            string Expiration_Date_M = "//span[text()='May']";//(case 60 XPATH for Expiration Date--->CLICK MONTH(EX: MAY))
            string Expiration_Date_click = "(//td[text()='18'])[2]";//(case 61 XPATH for Expiration Date--->CLICK Date)
            string Market_Segment = "(//select[@class='form-control error-aon-blur'])[1]";//(case 62 xpath for Market Segment)
            string Submission_Next = "(//a[@class='btn btn-primary'])[2]";//(case 63 XPATH for Next Button==>submission screen)
            string Amateur = "(//ins[@class='iCheck-helper'])[3]";//(case 64 XPATH for Census==>Amateur Sports)
            string ClassDetail_Save = "(//a[@class='btn btn-primary'])[5]";//(case 65 XPATH for class detail "save")
            string TwentyFour_Hour = "(//ins[@class='iCheck-helper'])[1]";//(case 66 XPATH for class 1 hazard (24 Hour Coverage))
            string School_Coverage = "(//ins[@class='iCheck-helper'])[42]";//(case 67 XPATH for class 1 hazard (School Coverage))
            string School_Coverage_Limitation = "(//ins[@class='iCheck-helper'])[43]";//(case 68 XPATH for class 1 hazard (School Coverage)==>Limitation Under Multiple Hazards)
            string Covered_Activities = "(//ins[@class='iCheck-helper'])[154]";//(case 69 XPATH for Class 1 - Covered Activities)
            string N_Button = "//input[@class='btn btn-primary jqhandlenextbutton']";//(case 70 XPATH for N Button)
            string SelectAll = "//a[@onclick='return CheckUnCheckGrid1(1);']";//(case 71 XPATH for Additional Benefit Checklist for Class 1==>//SELECT ALL)
            string Commission_Netted = "(//ins[@class='iCheck-helper'])[5]";//(case 72 XPATH for Commission Netted:)
            string TPA_Netted = "(//ins[@class='iCheck-helper'])[7]";//(case 73 XPATH for TPA Fee Netted:)
            string Review_PD = "(//ins[@class='iCheck-helper'])[2]";//(case 74 XPATH for Review/Verify Plan Design)
            string POP_OK_PD = "(//a[@class='btn btn-primary btn-custom-modal btn-xs LockDblConfirm'])[8]";//(case 75 XPATH for Alert pop up ok)
            string Down_Arrow = "(//i[@class='fa fa-arrow-down fa-mx'])[200]";//(case 76 XPATH for down arrow  after completeing PD)
            string class1_Hazard = "//a[text()='Class 1> Accident Medical and Dental Expense :: AME - [HMOPPO]  is not applicable/allowed in AK']";//(case 77 XPATH for Hazards :: Independent Contractor Coverage) 
            string class1_hazard_VT = "//a[text()='Class 1> Accident Medical and Dental Expense :: weeks option is not available for AME - [Period] in VT']";//(case 78 XPATH for Accident Medical and Dental Expense :: weeks option is not available for AME ) 
            string NewJersey_Limitation = "(//a[text()='Exclusions and Limitations :: The Exclusion : Aggravation or re-injury failed the validation.'])[2]";//(case 79 XPATH for The Exclusion : Aggravation or re-injury failed the validation)
            string Select_All_State = "(//ins[@class='iCheck-helper'])[1]";//(case 80 XPATH for Select all state)
            string Document_Search_Page = "//div/h2[contains(text(),'Document Search')]";//(case 81 XPATH for Document search page)
            string Search_Drop_Down = "(//ul[@class='dropdown-menu']/li)";//(case 82 XPATH for Search Drop Down)
            string Submission = "(//h2/span)[2]";//(case 83 XPATH for SUBMISSION)
            string Reports_Items = "(//ul[@class='dropdown-menu'])[5]";//(case 84 XPATH for list of Report items)
            string Pager_Control = "(//tr/td)[109]";//(case 85 XPATH for Pager Control)
            string Processed_Status_File = "(//i[@class='fa fa-download fa-mx'])[7]";//(case 86 XPATH for Processed_Status_File)
            string Processed_View_Detail = "(//i[@class='fa fa-arrow-circle-right fa-2x'])[3]";//(case 87 XPATH for Processed file _View_Detail)
            string Account_Name_Processed_File = "//a[@id='ctl00_cphMain_grdMGUUploads_ctl02_lnkButton']";//(case 88 XPATH for Account_Name_Processed_File)
            switch (which_object)
            {
                
                case 1:
                    required_object = user_id;
                    break;
                case 2:
                    required_object = password;
                    break;
                case 3:
                    required_object = login_button;
                    break;
                case 4:
                    required_object = dashboard;
                    break;
                case 5:
                    required_object = underwriting;
                    break;
                case 6:
                    required_object = manage_plandesign;
                    break;
                case 7:
                    required_object = label_manage_PD;
                    break;
                case 8:
                    required_object = Add_button_PD;
                    break;
                case 9:
                    required_object = Label_Account_Information;
                    break;
                case 10:
                    required_object = FD1_Plan_Design_Name;
                    break;
                case 30:
                    required_object = button_Close;
                    break;
                case 31:
                    required_object = Export_to_Excel;
                    break;
                case 32:
                    required_object = Report;
                    break;
                case 33:
                    required_object = Label_MGU_Upload_Log;
                    break;
                case 34:
                    required_object = MGU_Code;
                    break;
                case 35:
                    required_object = search;
                    break;
                case 36:
                    required_object = Name_of_the_file;
                    break;
                case 37:
                    required_object = download_file;
                    break;
                case 38:
                    required_object = view_detail;
                    break;
                case 39:
                    required_object = Export_to_Excel_MGU;
                    break;
                case 40:
                    required_object = Account_Name;
                    break;
                case 41:
                    required_object = MGU_Upload_Log;
                    break;
                case 42:
                    required_object = search_Menue;
                    break;
                case 43:
                    required_object = Document_Search;
                    break;
                case 44:
                    required_object = button_MGU_File_Upload;
                    break;
                case 45:
                    required_object = Enter_MGU_Code;
                    break;
                case 46:
                    required_object = button_upload_file;
                    break;
                case 47:
                    required_object = button_file_processing;
                    break;
                case 48:
                    required_object = button_FP_PopUp_Close;
                    break;
                case 49:
                    required_object = Bound_Business_File_Upload;
                    break;
                case 50:
                    required_object = Error_File_Upload;
                    break;
                case 51:
                    required_object = MGU_Download_Template;
                    break;
                case 52:
                    required_object = State_Alaska;
                    break;
                case 53:
                    required_object = State_NewJersey;
                    break;
                case 54:
                    required_object = State_Vermont;
                    break;
                case 55:
                    required_object = Effective_Date;
                    break;
                case 56:
                    required_object = Effective_Date_Today;
                    break;
                case 57:
                    required_object = Expiration_Date;
                    break;
                case 58:
                    required_object = Expiration_Date_Month;
                    break;
                case 59:
                    required_object = Expiration_Date_Symbol;
                    break;
                case 60:
                    required_object = Expiration_Date_M;
                    break;
                case 61:
                    required_object = Expiration_Date_click;
                    break;
                case 62:
                    required_object = Market_Segment;
                    break;
                case 63:
                    required_object = Submission_Next;
                    break;
                case 64:
                    required_object = Amateur;
                    break;
                case 65:
                    required_object = ClassDetail_Save;
                    break;
                case 66:
                    required_object = TwentyFour_Hour;
                    break;
                case 67:
                    required_object = School_Coverage;
                    break;
                case 68:
                    required_object = School_Coverage_Limitation;
                    break;
                case 69:
                    required_object = Covered_Activities;
                    break;
                case 70:
                    required_object = N_Button;
                    break;
                case 71:
                    required_object = SelectAll;
                    break;
                case 72:
                    required_object = Commission_Netted;
                    break;
                case 73:
                    required_object = TPA_Netted;
                    break;
                case 74:
                    required_object = Review_PD;
                    break;
                case 75:
                    required_object = POP_OK_PD;
                    break;
                case 76:
                    required_object = Down_Arrow;
                    break;
                case 77:
                    required_object = class1_Hazard;
                    break;
                case 78:
                    required_object = class1_hazard_VT;
                    break;
                case 79:
                    required_object = NewJersey_Limitation;
                    break;
                case 80:
                    required_object = Select_All_State;
                    break;
                case 81:
                    required_object = Document_Search_Page;
                    break;
                case 82:
                    required_object = Search_Drop_Down;
                    break;
                case 83:
                    required_object = Submission;
                    break;
                case 84:
                    required_object = Reports_Items;
                    break;
                case 85:
                    required_object = Pager_Control;
                    break;
                case 86:
                    required_object = Processed_Status_File;
                    break;
                case 87:
                    required_object = Processed_View_Detail;
                    break;
                case 88:
                    required_object = Account_Name_Processed_File;
                    break;




            }

            return required_object;

        }


        public static string Create_new_Account(int which_object)
        {

            string new_account_button = "//a[normalize-space()='Create a new account']"; // new account button xpath
            string compare_label = "//p[@class='text-muted m-0']";// let's get started label xpath
            string first_name = "#mat-input-3";// first_name cssselector
            string last_name = "#mat-input-4";// last_name cssselector
            string user_name = "#mat-input-5";//user_name cssselector
            string email = "#mat-input-4";// email cssselector
            string password = "#mat-input-5";// password cssselector
            string confirm_password = "#mat-input-6";// confirm_password cssselctor
            string agree_checkbox = "//span[@class='mat-checkbox-inner-container']"; //agree check box css xpath
            string sign_up = "//span[@class='mat-button-wrapper']";// absolute xpath of signup button
            switch (which_object)
            {
                case 1:

                    required_object = new_account_button;
                    break;
                case 2:
                    required_object = compare_label;
                    break;
                case 3:
                    required_object = first_name;
                    break;
                case 4:
                    required_object = last_name;
                    break;

                case 5:
                    required_object = user_name;
                    break;
                case 6:
                    required_object = email;
                    break;
                case 7:
                    required_object = password;
                    break;
                case 8:
                    required_object = confirm_password;
                    break;
                case 9:
                    required_object = agree_checkbox;
                    break;
                case 10:
                    required_object = sign_up;
                    break;

            }


            return required_object;

        }

        public static string savedAmount()
        {

            string ModelsavedAmount = "#savedAmount";
            return ModelsavedAmount;
        }
    }
}
