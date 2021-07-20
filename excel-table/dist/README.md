## Excel Table

A jQuery based plugin to convert HTML tables into Excel like grids with features like range selection, drag-paste, copy, paste, undo, etc.

### How to Use the library

Check out the demo folder and open index.html file. You'll will see how we've used the plugin there with few simple steps. 

### Usage

```markdown

$(function(){
  // With options
  var options = {
    name: 'my-excel-table',
  };
  $('.table-selector').exceltable(options); 

  // Or without options
  $('.table-selector').exceltable(); 
});

```
