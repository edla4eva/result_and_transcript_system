    <?php 
    //header('Content-type: application/json');  causes problems in hosting use calling ajax 
    define('BASEPATH', '');
    define('CONNECTPATH', '');
    require_once 'connect.php';
    //here prepare the query for analyzing, prepared statements use less resources and thus run faster  
    $row=$db->prepare('select * from efamily WHERE approved = "1"'); //LIMIT 1,100; LIMIT 101,100;  //LIMIT offset rows
    $row->execute();//execute the query  
    $json_data=array();//create the array  
    foreach($row as $rec)//foreach loop  
    {  
    $json_array['id']=$rec['id'];  
        $json_array['first_name']=$rec['first_name'];   
        $json_array['sur_name']=$rec['sur_name'];  
        $json_array['parent_idr']=$rec['parent_idr'];  
        $json_array['year']=$rec['year']; 
        $json_array['gender']=$rec['gender'];   
        $json_array['depth']=$rec['parent_idr'];               
    //here pushing the values in to an array  
        array_push($json_data,$json_array);        
    }  
    $db_data_json=trim(json_encode($json_data)); 
    echo $db_data_json;  
?>