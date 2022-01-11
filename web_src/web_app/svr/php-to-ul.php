
    <?php  
    
    define('CONNECTPATH', '');
    require_once 'connect.php'
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
   // print_r($json_data); //test
    
    //built in PHP function to encode the data in to JSON format 
    //$db_data_json=trim(json_encode($json_data));   
    //$json_decode = htmlspecialchars(json_encode($json_data), ENT_QUOTES, 'UTF-8');


    // here creating ul
    $tree = categoriesToTree($json_data); //create tree from array
    echo "=== TREE ===\n";
    print_r ($tree);
    echo '<ul id="myUL">';
    ToUl($tree);  // best option for ul - directly echo the ul
    echo '</ul>';
        
function printArrayList($array)
{
    echo "<ul>";
    foreach($array as $k => $v) {
        if (is_array($v)) {
            echo '<li><span class="caret">'.'first_name'.'</span><ul class="nested">';
            printArrayList($v);
            echo  '</ul> </li>';
            continue;
        }
       if  ($k=='first_name') echo "<li>" . $v . "</li>";
    }
    echo "</ul>";
}

$output ='';
//<li><span class="caret">Ishoshenho(1755?)</span><ul class="nested">
function ToUl($input){
   // echo '<ul id="myUL">';
 
    $oldvalue = null;
    foreach($input as $key =>$value){

      if($oldvalue != null && !is_array($value))
        echo "</li>"; 

      if(is_array($value)){
        echo '<li class="caret">' . 'name' . '<ul class="nested">'.  ToUl($value) .'</ul>'; //. '<ul class="nested"> </ul>';
      }else
     
      if  ($key=='first_name') echo "<li>" . $value . "</li>" ;
       $oldvalue = $value;
     }
 
    //echo "</ul>";
 }
 
        
      //Other options
      $json_test_data = array(
        array('id' => 1,  'parent_idr' => 0, 'first_name' => 'Any name (root)'),
        array('id' => 2,  'parent_idr' => 0, 'first_name' => 'Category B'),
        array('id' => 3,  'parent_idr' => 0, 'first_name' => 'Category C'),
        array('id' => 4,  'parent_idr' => 0, 'first_name' => 'Category D'),
        array('id' => 5,  'parent_idr' => 0, 'first_name' => 'Category E'),
        array('id' => 6,  'parent_idr' => 2, 'first_name' => 'Subcategory F'),
        array('id' => 7,  'parent_idr' => 2, 'first_name' => 'Subcategory G'),
        array('id' => 8,  'parent_idr' => 3, 'first_name' => 'Subcategory H'),
        array('id' => 9,  'parent_idr' => 4, 'first_name' => 'Subcategory I'),
        array('id' => 10, 'parent_idr' => 9, 'first_name' => 'Subcategory J'),
    );
    
    function categoriesToTree(&$json_data) {
    
        $map = array(
            0 => array('Children' => array())
        );
    
        foreach ($json_data as &$category) {
            $category['Children'] = array();
            $map[$category['id']] = &$category;
        }
    
        foreach ($json_data as &$category) {
            $map[$category['parent_idr']]['Children'][] = &$category;
        }
    
        return $map[0]['Children'];
    
    }
    
   // echo "=== BEFORE ===\n";
   // print_r ($categories);
    
    //$tree = categoriesToTree($json_data);

    //echo "=== AFTER ===\n";
    //print_r ($categories);
    
    //echo "=== TREE ===\n";
    //print_r ($tree);
    //echo "=== UL(1) ===\n </br>";
    //printArrayList($tree);
    //echo "=== UL(2) ===\n </br>";
    //ToUl($tree);  // best option



        //$db_data_ul='<ul>'. getMenu('0').'</ul>'; //<ul><li>ii</li><
        //echo  $db_data_ul;      
  
/*     $getMenu = new Func("getMenu", function($parentID = null, $input_data = null) {
    $getMenu = Func::getCurrent();
    return call_method(call_method($input_data, "filter", new Func(function($node = null) use (&$parentID) {
        return get($node, "parent_id") === $parentID;
    })), "map", new Func(function($node = null) use (&$input_data, &$getMenu) {
        $exists = call_method($input_data, "some", new Func(function($childNode = null) use (&$node) {
        return get($childNode, "parent_id") === get($node, "id");
        }));
        $subMenu = is($exists) ? _concat("<ul>", call_method(call($getMenu, get($node, "id")), "join", ""), "</ul>") : "";
        return _concat("<li>", get($node, "name"), $subMenu, "</li>");
    }));
    }); 
    
    
    //echo make_ulli($json_data);  

        function make_ulli($array){
            if(!is_array($array)) return '';
           // print_r(array_map("is_parent",$array));
            $output = '<ul>';
            foreach($array as $item){  
        
                    
                echo '</br> output is '.$output;
            if(is_parent_id($item['id'],$array)){
                $output .= '<li><span class="caret">' . $item['first_name'].'</li>'; //.= make_ulli($item)
               // print_r(array_map("add_children",$array));
            //}elseif{
                   // $output='<ul id="myUL">'.$output.'</ul>';
               // $output .= '</li>';
            }
            }   
            $output .= '</ul>';
        
            return $output;
        }
    
    
    */


      
    ?>  