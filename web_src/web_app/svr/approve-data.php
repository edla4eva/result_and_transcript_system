
<!DOCTYPE html>
<html>
<body>

<?php
defined('BASEPATH') OR exit('No direct script access allowed');
define('CONNECTPATH', '');
require_once 'connect.php';

if ($con->connect_error) {
    die("Connection failed: " . $con->connect_error);
}
//<!-- id 	first_name 	sur_name 	title 	parent_idr 	has_children 	children_names 	dob  year 	is_alive 	gender 	pix 	bio 	paternal_maternal 	dod 	 -->
    
$sql = "SELECT * FROM efamily WHERE approved=1";
$result = $con->query($sql);

echo sql_to_html_table( $result, $delim="\n" ) ; 


function sql_to_html_table($sqlresult, $delim="\n") {
    // starting table
    $htmltable =  "<table>" . $delim ;   
    $counter   = 0 ;
    // putting in lines
    while( $row = $sqlresult->fetch_assoc()  ){
      if ( $counter===0 ) {
        // table header
        $htmltable .=   "<tr>"  . $delim;
        foreach ($row as $key => $value ) {
            $htmltable .=   "<th>" . $key . "</th>"  . $delim ;
        }
        $htmltable .=   "</tr>"  . $delim ; 
        $counter = 22;
      } 
        // table body
        $htmltable .=   "<tr>"  . $delim ;
        foreach ($row as $key => $value ) {
            $htmltable .=   "<td>" . $value . "</td>"  . $delim ;
        }
        $htmltable .=   "</tr>"   . $delim ;
    }
    // closing table
    $htmltable .=   "</table>"   . $delim ; 
    // return
    return( $htmltable ) ; 
  }



$con->close();
?>

</body>
</html>
