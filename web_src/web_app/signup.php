<?php 
define('BASEPATH', '');
session_start(); /* Starts the session */
$msg="";
if ($_SERVER["REQUEST_METHOD"] == "GET") {
  if (isset($_GET["msg"])) $msg = $_GET["msg"];
  
  if ($msg=="-1") $msg="Could not add signIn! Username already exists!";
  if ($msg=="-2") $msg="Could not add signIn! Database error";
}
include 'index.php'; //dont add #signup
?>
