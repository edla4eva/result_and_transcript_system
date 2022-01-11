<?php
$DATABASE_HOST = 'localhost';  //
$DATABASE_USER = 'descsfww_admin';  //
$DATABASE_PASS = 'SITEdbo}4A9Dppv#4vEOBADAN';  //cpanel pass klIKiWTiHAq2
$DATABASE_NAME = 'descsfww_efamily'; 
try{
	$con = mysqli_connect($DATABASE_HOST, $DATABASE_USER, $DATABASE_PASS, $DATABASE_NAME); // Try and connect using the info above.
	$db=new PDO('mysql:host='.$DATABASE_HOST.';dbname='.$DATABASE_NAME.';charset=utf8', $DATABASE_USER, $DATABASE_PASS);  
} catch (PDOException $e) {
	error_log('Connection failed: ' . $e->getMessage()); //, 3, "/tmp/efamilyerrors.log"); //log it
	throw $e; //rethrow it	
}
?>