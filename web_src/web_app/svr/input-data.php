<?php 
define('CONNECTPATH', '');
require_once 'connect.php';
    // works header("location:../home.html");
session_start(); /* Starts the session */

$name = $email = $gender = $comment = $website = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $pass = test_input($_POST["inputPassword"]);
  $email = test_input($_POST["inputEmail"]);
 
  $first_name = test_input($_POST["first_name"]);
  $sur_name = test_input($_POST["sur_name"]);
  $title = test_input($_POST["title"]);
  $parent_idr = test_input($_POST["parent_idr"]);
  $has_children = test_input($_POST["has_children"]);
  $children_names = test_input($_POST["children_names"]);
  $dob = test_input($_POST["dob"]);

  $year = test_input($_POST["year"]);
  $is_alive = test_input($_POST["is_alive"]);
  $gender = test_input($_POST["gender"]);
  $pix = test_input($_POST["pix"]);
  $bio = test_input($_POST["bio"]);
  $paternal_maternal = test_input($_POST["paternal_maternal"]);
  $dod = test_input($_POST["dod"]);
  $other_names = test_input($_POST["other_names"]);


  /* Define username and associated password array */

  //id 	first_name 	sur_name 	title 	parent_idr 	has_children 	children_names 	dob 	year 	
//is_alive 	gender 	pix 	bio 	paternal_maternal 	dod 	other_names
// prepare and bind
//$stmt = $con->prepare('INSERT INTO requests (id, first_name, sur_name, title, parent_idr, has_children,     children_names, dob, `year`, is_alive, gender, pix, bio, paternal_maternal, dod, other_names) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)');
//                          $stmt->bind_param('', $first_name, $sur_name, $title, $parent_idr, $has_children, $children_names, $dob, $year, $is_alive, $gender, $pix, $bio, $paternal_maternal, $dod, $other_names);


$sql = 'INSERT INTO efamily (first_name, sur_name, title, parent_idr, has_children, children_names, dob, `year`, is_alive, gender, pix, bio, paternal_maternal, dod, other_names) 
VALUES ("'.$first_name.'", "'.$sur_name.'", "'.$title.'", "'.$parent_idr.'", "'.$has_children.'", "'.$children_names.'", "'.$dob.'", "'.$year.'", "'.$is_alive.'", "'.$gender.'", "'.$pix.'", "'.$bio.'", "'.$paternal_maternal.'", "'.$dod.'", "'.$other_names.'")';
 try
 {
  $result = $con->query($sql);
  if ($result > 0) {
    $msg="<span style='color:blue'>New records created successfully</span></br>";
    header("location:input-success.php"); //show success
  }else{
    $msg= '-1'; "<span style='color:red'>New records could not be added</span></br>";
    header("location:../input.php?msg=-1"); //show success
  }
  
 } catch (Exception $e) {
  error_log( 'Exception caught by eFamily App: '.$e->getMessage());
 }

  /* // set parameters and execute
$first_name = "John"; 
$sur_name = "Doe";
$email = "john@example.com";
$year = "1900";
$parent_idr = "1";
$dob = "01-01-1900";
//$approved = "no";
$stmt->execute();
 */



} //end if



function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}

?>