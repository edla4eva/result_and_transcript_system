<?php 
error_reporting(E_ALL); //TODO: remove error reporting
ini_set('display_errors', 1);
define('CONNECTPATH', '');
try {
    require_once 'connect.php';
}  catch(Exception $e) {
    //header("location:fancy-error.php?msg=db");
    require_once 'fancy-error.php'; //also works
    exit;
 }
session_start(); /* Starts the session */


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = isset($_POST['username']) ? test_input($_POST['username']) : '';
    $password = isset($_POST['inputPassword']) ? md5(test_input($_POST['inputPassword'])) : '';
   // $password=hash('sha256',$password); //todo: encrypt
   try{
    if ($con->connect_error) {
        $msg="<span style='color:red'>Invalid Login Details</span>";
        header("location:../sign-in.php?msg=-2S");
        exit;
    }
       // echo "input username: ".$username;
        $sql = 'SELECT * FROM users WHERE (username= ? AND password= ?);';
        $row = $con->prepare($sql);
        $row->bind_param( "ss", $username, $password);

        
        $row->execute();
        $result=$row->get_result();//print_r($result);
        
        if ($result->num_rows > 0) {
            // output data of each row
            while($row = $result->fetch_assoc()) {
            // echo "id: " . $row["user_id"]. " - username: " . $row["username"].  "<br>";
            // echo "efamily id: " . $row["efamily_id"];
                $_SESSION['UserData']['inputEmail']=$username;
                $_SESSION['UserData']['username']=$username;
                $id=$row['efamily_id'];
                $_SESSION['UserData']['id']=$id;
                header("location:../home.php");
            }
        } else {
            //echo "0 results";
            header("location:../sign-in.php?msg=-1");
            exit;
        }
        $con->close();
    }  catch(Exception $e) {
        //We cant add tell user
        $msg="<span style='color:red'>Invalid Login Details</span>";
        header("location:../sign-in.php?msg=-1");
        exit;
    }
    //$sql = 'SELECT * FROM users WHERE (username="'.$username.'" AND password="'.$password.'");';
    
    // $sql = 'SELECT * FROM users WHERE (username= ":username" AND password= "admin");';
    // $result=$con->prepare($sql);  
    // echo $con->error;
    // $result->bindParam( "username", $username);
    // //$result->bindParam("password", $password);
    // $result->execute();//execute the query  
    // try{
    //     $result = $con->query($sql);  //mysqli
    //     //-------------

    //     //---------------
    //     if($result->num_rows>0){
    //         /* Success: Set session variables and redirect to Protected page  */
    //         $_SESSION['UserData']['inputEmail']=$username;
    //         $_SESSION['UserData']['username']=$username;
    //         //mysqli
    //         $rows=$result->get_result();
    //         $users=$result->fetch_assoc();
    //         print_r ($users);
    //         exit;
    //         while ($row=mysqli_fetch_array($result))
    //         {
    //             $id=$row['efamily_id'];
    //         }
    //         $_SESSION['UserData']['id']=$id;
    //         header("location:../home.php");
    //         exit; //000webhost and make sure nothing is echoed
    //     } else {
    //         $msg="<span style='color:red'>Invalid Login Details</span>";
    //         header("location:../sign-in.php?msg=-2");
    //         exit; //000webhost
    //     }
    // }  catch(Exception $e) {
    //     //We cant add tell user
    //     $msg="<span style='color:red'>Invalid Login Details</span>";
    //     header("location:../sign-in.php?msg=-1");
    //     exit;


    // }
} //enf if POST

function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
?>