
    <?php  
    define('CONNECTPATH', '');
    require_once 'connect.php';
    //here prepare the query for analyzing, prepared statements use less resources and thus run faster  
    $row=$db->prepare('select * from efamily');  
      
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

    
    //built in PHP function to encode the data in to JSON format 
    $db_data_json=trim(json_encode($json_data)); 
    //echo $db_data_json;  
    echo '{"id": "1", "name": "name_1", "parent_id": "0", "depth": "0"}';
    //$json_decode = htmlspecialchars(json_encode($json_data), ENT_QUOTES, 'UTF-8');




    
      
    ?>  