﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Hospital_Management_System.contact" %>

<!DOCTYPE html>

<html>

	<head>
		<meta charset="UTF-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
	    <meta name="viewport" content="width=device-width, initial-scale=1">
		<title>HOSPITAL MANAGEMENT SYSTEM | CONTACT</title>

	    <link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css'>
	    <!-- <link href='http://fonts.googleapis.com/css?family=Pontano+Sans' rel='stylesheet' type='text/css'>
	    <link href='http://fonts.googleapis.com/css?family=Alegreya+Sans:300,400,500,700' rel='stylesheet' type='text/css'> -->
	    <link href='http://fonts.googleapis.com/css?family=Roboto:400,300,500' rel='stylesheet' type='text/css'>
	    <link href='http://fonts.googleapis.com/css?family=Dosis:300,400,500,600' rel='stylesheet' type='text/css'>
	    
		
		<link rel="stylesheet" type="text/css" href="assets/css/animate.css">
		<link rel="stylesheet" type="text/css" href="assets/css/bootstrap.min.css">
		<link rel="stylesheet" type="text/css" href="assets/css/font-awesome.min.css">
		<link rel="stylesheet" type="text/css" href="assets/css/main.css">
		<link rel="stylesheet" href="css/tooplate-style.css" />
	</head>

	<body>
	 <!-- Loader -->
    <div id="loader-wrapper">
      <div id="loader"></div>
      <div class="loader-section section-left"></div>
      <div class="loader-section section-right"></div>
    </div>
		<section class= "navs">
			<nav class="navbar navbar-default navbar-fixed-top" role="navigation">
  				<div class="container-fluid">
    				<!-- Brand and toggle get grouped for better mobile display -->
    				<div class="navbar-header">
      					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
					        <span class="sr-only">Toggle navigation</span>
					        <span class="icon-bar"></span>
					        <span class="icon-bar"></span>
					        <span class="icon-bar"></span>
	      				</button>
	      				<a class="navbar-brand logo" href="home.aspx">
	      					<span><i class="fa fa-stethoscope"></i></span>
	      					Hospital Management System
	      				</a>
	    			</div>

    		<!-- Collect the nav links, forms, and other content for toggling -->
				    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
				    	<ul class="nav navbar-nav navbar-right">
					        <li class="active"><a href="home.aspx">Home</a></li>
							<li><a href="doctors.aspx">Doctors</a></li>
					        <li><a href="services.aspx">Services</a></li>
							<li><a href="signin_patient.aspx">Signin</a></li>
							<li><a href="faq.aspx">FAQs</a></li>
							<li><a href="noticeboard.aspx">NoticeBoard</a></li>
							<li><a href="contact.aspx">Contact Us</a></li>
				      	</ul>
				    </div><!-- /.navbar-collapse -->
				</div><!-- /.container-fluid -->
			</nav>
		</section>

		<section class="contact-title text-center">
			<div class="contact-wrapper">
				<div class="container">
					<div class= "row">
						<div>
							<h1 class="headline">Contact us</h1>
						</div>
					</div>
						
				</div>
			</div>
		</section>


		<section class="contact-content">
			<div class="container">
				<div class="row">
					<div class="col-md-8">
						<div class="google-map">
							<div id="map-canvas"></div>
						</div>
						<div class="quick-contact">
							<h3>Quick Contact</h3>
							<hr>
							<div class="row">
								<div class="col-md-6">
									<p>
										<i class="fa fa-home"></i> 
										<span>Full Address:</span> 
										Chandigarh University
									</p>
								</div>
								<div class="col-md-6">
									<p>
										<i class="fa fa-phone"></i>
										<span>Cell No:</span>
										 +91 1234567890
									</p>
								</div>
							</div>
							<div class="row">
								<div class="col-md-6">
									<p>
										<i class="fa fa-fax"></i> 
										<span>Fax No:</span>
										+91 - 0123456789
									</p>
								</div>
								<div class="col-md-6">
									<p>
										<i class="fa fa-ambulance"></i>
										<span>Ambulance:</span>
										 + 101
									</p>
								</div>
							</div>
						</div>
					</div>

					<div class="col-md-4">
						<div class= "appointment">
							
		                    <div class="header text-center">
		                        <h2>Contact Us</h2>
		                       	
		                    </div>

							<!-- form of appointment -->
							<div class="row">
								<form method="post" runat="server">
									<div class= "form">
										<div class="input-group margin-bottom-sm col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1">
										 
                                            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Full Name *" required></asp:TextBox>
										</div>
										<div class="input-group margin-bottom-sm col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1">
										 	
                                            <asp:TextBox ID="TextBox2" runat="server"  class="form-control" placeholder="Email Address *" required></asp:TextBox>
										</div>
										
										<div class="input-group margin-bottom-sm col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1">
										 
                                            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Subject *" required></asp:TextBox>
										</div>
										<div class="input-group margin-bottom-sm col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1">
                                            <asp:TextBox ID="TextBox4" runat="server" class="form-control" cols="30" rows="10" placeholder="What would you like to tell us"></asp:TextBox>
										</div>
										
									</div>
									
									<div class="col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1">
										
									<asp:Button ID="Button1" runat="server" Text="Send" class="btn btn-primary send" 
                                            onclick="Button1_Click"></asp:Button>
									&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label" 
                                            Visible="False"></asp:Label>
									</div>
								</form>
							</div>
							<!-- end of form -->
						</div><!-- end of appointment-->
					</div>
				</div>
			</div>
		</section>


		<section id="footer">
			<div class="container">
				<div class="row">
					<div class="col-md-6 col-md-offset-3">
						<ul class="text-center contact">
				        	<li class= "socials-icons">
								<a href="#" data-toggle="tooltip" title="Share in Facebook" class="facebook"><i class="fa fa-facebook"></i></a>
							</li>
							<li class= "socials-icons">
								<a href="#" data-toggle="tooltip" title="Share in Twitter" class="twitter"><i class="fa fa-twitter"></i></a>
							</li>
							<li class= "socials-icons">
								<a href="#" data-toggle="tooltip" title="Share in Google +" class="google-plus"><i class="fa fa-google-plus"></i></a>
							</li>
							<li class= "socials-icons">
								<a href="#" data-toggle="tooltip" title="Share in Instagram" class="instagram"><i class="fa fa-instagram"></i></a>
							</li>
							
							<li class= "socials-icons">
								<a href="#" data-toggle="tooltip" title="Connect with Skype" class="skype"><i class="fa fa-skype"></i></a>
							</li>
				      	</ul>
					</div>
				</div>
				
			</div>
		</section>


		<script type="text/javascript" src="assets/js/jquery.min.js"></script>
		<script type="text/javascript" src="assets/js/isotope.pkgd.min.js"></script>
		<script type="text/javascript" src="assets/js/wow.min.js"></script>
		<script type="text/javascript" src="assets/js/bootstrap.min.js"></script>
		<script src="https://maps.googleapis.com/maps/api/js"></script>
		
    <script>


        window.onload = function () {
            $("body").addClass("loaded");
        };
	  
	

      
    </script>
		<script>
		    function initialize() {
		        var mapCanvas = document.getElementById('map-canvas');
		        var mapOptions = {
		            center: new google.maps.LatLng(24.900392, 91.853181),
		            zoom: 16,
		            mapTypeId: google.maps.MapTypeId.ROADMAP
		        }
		        var map = new google.maps.Map(mapCanvas, mapOptions)
		    }
		    google.maps.event.addDomListener(window, 'load', initialize);
	    </script>

		<script>
		    new WOW().init();
		</script>


	</body>
</html>
