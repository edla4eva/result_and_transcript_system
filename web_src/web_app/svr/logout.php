<?php
define('BASEPATH', '');
defined('BASEPATH') OR exit('No direct script access allowed');

//session_start();
//unset($_SESSION['id']);
//header("location:../sign-in.html"); 
?>

<?php 

session_start(); /* Starts the session */
if(isset($_SESSION['UserData']['inputEmail'])){
    session_unset();
    session_destroy();
}
header("location:../index.php");
exit;
?>