<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_and_view_donor.aspx.cs" Inherits="Hospital_Management_System.add_and_view_donor" %>

<!DOCTYPE html>
<html lang="en"> 
<head>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <title> Admin Panel | Add and View Donor</title>
      <!-- Start Global Mandatory Style
         =====================================================================-->
      <!-- jquery-ui css -->
      <link href="assets1/plugins/jquery-ui-1.12.1/jquery-ui.min.css" rel="stylesheet" type="text/css"/>
      <!-- Bootstrap -->
      <link href="assets1/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
      <!-- Bootstrap rtl -->
      <!--<link href="assets1/bootstrap-rtl/bootstrap-rtl.min.css" rel="stylesheet" type="text/css"/>-->
      <!-- Lobipanel css -->
      <link href="assets1/plugins/lobipanel/lobipanel.min.css" rel="stylesheet" type="text/css"/>
      <!-- Pace css -->
      <link href="assets1/plugins/pace/flash.css" rel="stylesheet" type="text/css"/>
      <!-- Font Awesome -->
      <link href="assets1/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>
      <!-- Pe-icon -->
      <link href="assets1/pe-icon-7-stroke/css/pe-icon-7-stroke.css" rel="stylesheet" type="text/css"/>
      <!-- Themify icons -->
      <link href="assets1/themify-icons/themify-icons.css" rel="stylesheet" type="text/css"/>
      <!-- End Global Mandatory Style
         =====================================================================-->
      <!-- Start page Label Plugins 
         =====================================================================-->
      <!-- Emojionearea -->
      <link href="assets1/plugins/emojionearea/emojionearea.min.css" rel="stylesheet" type="text/css"/>
      <!-- Monthly css -->
      <link href="assets1/plugins/monthly/monthly.css" rel="stylesheet" type="text/css"/>
      <!-- End page Label Plugins 
         =====================================================================-->
      <!-- Start Theme Layout Style
         =====================================================================-->
      <!-- Theme style -->
      <link href="assets1/dist/css/stylecrm.css" rel="stylesheet" type="text/css"/>
      <!-- Theme style rtl -->
      <!--<link href="assets1/dist/css/stylecrm-rtl.css" rel="stylesheet" type="text/css"/>-->
      <!-- End Theme Layout Style
         =====================================================================-->
		 <link rel="stylesheet" href="css/tooplate-style.css" />
   </head>
   <body class="hold-transition sidebar-mini">
      <!--preloader --->
         <div id="loader-wrapper">
      <div id="loader"></div>
      <div class="loader-section section-left"></div>
      <div class="loader-section section-right"></div>
    </div>
      <!-- Site wrapper -->
      <div class="wrapper">
         
         <!-- =============================================== -->
         <!-- Left side column. contains the sidebar -->
        <header class="main-header">
           <asp:PlaceHolder ID="PlaceHolder12" runat="server"></asp:PlaceHolder>
            <!-- Header Navbar -->
            <nav class="navbar navbar-static-top">
               <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
                  <!-- Sidebar toggle button-->
                  <span class="sr-only">Toggle navigation</span>
                  <span class="pe-7s-angle-left-circle"></span>
               </a>
              
               <div class="navbar-custom-menu">
                  <ul class="nav navbar-nav">
                     <!-- Orders -->
                    
                     <!-- Messages -->
                     
                     <!-- Notifications -->
                     
                     <!-- Tasks -->
                     
                     <!-- Help -->
                    
                     <!-- user -->
                     <li class="dropdown dropdown-user">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        <img src="assets1/dist/img/avatar5.png" class="img-circle" width="45" height="45" alt="user"></a>
                        <ul class="dropdown-menu" >
                        
                          
                           <li><a href="signin_admin.aspx">
                              <i class="fa fa-sign-out"></i> Signout</a>
                           </li>
                        </ul>
                     </li>
                  </ul>
               </div>
            </nav>
         </header>

         
         <!-- =============================================== -->
         <!-- Left side column. contains the sidebar -->
        <aside class="main-sidebar">
            <!-- sidebar -->
           <div class="sidebar">
               <!-- sidebar menu -->
               <ul class="sidebar-menu">
                  <li class="active">
                     <a href="#"><i class="fa fa-cubes"></i><span>Doctor</span>
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
					  
                  </li> 
                

                    <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Patient </span>
                     <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
					 
                   
                  </li> 
<li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Employee</span>
                    
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
					  
                  </li> 				  

                    <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Blood Bank </span>
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
					   
                   
                  </li>  
				   <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Pharmacy </span>
					  <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
					  
                    
                     
                   
                  </li> 
				   <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Test & Reports</span>
					  <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>
					 
                    
                    
                   
                  </li> 
        <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Appointments </span>
                     <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder>
					 
                  </li>  

				   <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Doctor Applied Leaves</span>
                     <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder8" runat="server"></asp:PlaceHolder>
					 
                   
                  </li> 
				   <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Ambulance </span>
                    
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder9" runat="server"></asp:PlaceHolder>
					  
                   
                  </li> 
				   <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Salary</span>
                    
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder10" runat="server"></asp:PlaceHolder>
                      
					   
                  </li> 
				
				  <li class="treeview">
                     <a href="">
                     <i class="fa fa-cubes"></i><span>Notice Board </span>
                    
                      <span class="pull-right-container">
                     <i class="fa fa-angle-left pull-right"></i>
                     </span>
                     </a>
                      <asp:PlaceHolder ID="PlaceHolder11" runat="server"></asp:PlaceHolder>
					   
                  </li> 
      

                    
               </ul> 
            </div>
            <!-- /.sidebar -->
         </aside>
         <!-- =============================================== -->
         <!-- Content Wrapper. Contains page content -->
         <div class="content-wrapper">
            <!-- Content Header (Page header) -->
            <section class="content-header">
               
              
            </section>
            <!-- Main content -->
            <section class="content">
               
                <center><table style="width:1500px; heigth:auto;" class="table">
<tr bgcolor="black">
<th colspan="7"><h2><center>ADD DONOR</center></h2></th>
</tr></table></center>
             <form id="form1" runat="server" style="color: #000000">

            <center> <div class="container">
    &nbsp;<br />
      <br />

    <label for="name"><b>Name</b></label>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox
        ID="TextBox1" runat="server"  ForeColor="Black" Width="734px" ></asp:TextBox>
        <br />
      
      <br />
      <label for="age"><b>Age</b></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2"   
          runat="server" ForeColor="Black" Width="734px"></asp:TextBox>

      <br />
      <br />

    <label for="email"><b>Email</b></label>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox
        ID="TextBox3" runat="server"  ForeColor="Black" Width="734px" ></asp:TextBox>
        <br />
      
      <br />
       <label for="number"><b>Phone</b></label>&nbsp;&nbsp;&nbsp;
     
    <asp:TextBox
        ID="TextBox4" runat="server"  ForeColor="Black" 
           Width="734px"></asp:TextBox>
        <br />
      
      <br />
     

    <label for="address"><b>Address</b></label>
     
    <asp:TextBox
        ID="TextBox5" runat="server"  ForeColor="Black" TextMode="MultiLine" 
          Height="52px" Width="734px"></asp:TextBox>
        <br />
      
      <br />
      <label for="blood_group"><b>Blood Group</b></label>
   <asp:DropDownList ID="DropDownList1" runat="server" Height="37px" Width="118px">
       <asp:ListItem>A+</asp:ListItem>
       <asp:ListItem>B+</asp:ListItem>
       <asp:ListItem>O+</asp:ListItem>
       <asp:ListItem>AB+</asp:ListItem>
       <asp:ListItem>A-</asp:ListItem>
       <asp:ListItem>B-</asp:ListItem>
       <asp:ListItem>O-</asp:ListItem>
       <asp:ListItem>AB-</asp:ListItem>
                 </asp:DropDownList>

      <br />
      <br />

   
      <br />
        
    
        
    <asp:Button ID="Button1" runat="server" Text="Add Donor" BackColor="#094987" 
          ForeColor="White" Height="52px" Width="50%" onclick="Button1_Click"   />
    
      <br />
      <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              
              
              <h2 style="color:White; background-color:Black; Height:52px; Width:99%;"><center>LIST OF  DONOR</center></h2>
              <center>


                  <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                      BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="3" 
                      GridLines="Vertical" Width="717px" HorizontalAlign="Center">
                      <AlternatingRowStyle BackColor="#DCDCDC" />
                      <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                      <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                      <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                      <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#0000A9" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#000065" />
                  </asp:GridView></center>  
    
  </div></center>
   
  
                     </form>
               <!-- /.row -->
            
            </section>
            <!-- /.content -->
         </div>

       
         <!-- /.content-wrapper -->
         <footer class="main-footer">
            
         </footer>	
      </div>
      <!-- /.wrapper -->
      <!-- Start Core Plugins
         =====================================================================-->
      <!-- jQuery -->
      <script src="assets1/plugins/jQuery/jquery-1.12.4.min.js" type="text/javascript"></script>
      <!-- jquery-ui --> 
      <script src="assets1/plugins/jquery-ui-1.12.1/jquery-ui.min.js" type="text/javascript"></script>
      <!-- Bootstrap -->
      <script src="assets1/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
      <!-- lobipanel -->
      <script src="assets1/plugins/lobipanel/lobipanel.min.js" type="text/javascript"></script>
      <!-- Pace js -->
      <script src="assets1/plugins/pace/pace.min.js" type="text/javascript"></script>
      <!-- SlimScroll -->
      <script src="assets1/plugins/slimScroll/jquery.slimscroll.min.js" type="text/javascript">    </script>
      <!-- FastClick -->
      <script src="assets1/plugins/fastclick/fastclick.min.js" type="text/javascript"></script>
      <!-- CRMadmin frame -->
      <script src="assets1/dist/js/custom.js" type="text/javascript"></script>
      <!-- End Core Plugins
         =====================================================================-->
      <!-- Start Page Lavel Plugins
         =====================================================================-->
      <!-- ChartJs JavaScript -->
      <script src="assets1/plugins/chartJs/Chart.min.js" type="text/javascript"></script>
      <!-- Counter js -->
      <script src="assets1/plugins/counterup/waypoints.js" type="text/javascript"></script>
      <script src="assets1/plugins/counterup/jquery.counterup.min.js" type="text/javascript"></script>
      <!-- Monthly js -->
      <script src="assets1/plugins/monthly/monthly.js" type="text/javascript"></script>
      <!-- End Page Lavel Plugins
         =====================================================================-->
      <!-- Start Theme label Script
         =====================================================================-->
      <!-- Dashboard js -->
      <script src="assets1/dist/js/dashboard.js" type="text/javascript"></script>
      <!-- End Theme label Script
         =====================================================================-->
       <script>


           window.onload = function () {
               $("body").addClass("loaded");
           };
	  
	

      
    </script>
   </body>
 
</html>



