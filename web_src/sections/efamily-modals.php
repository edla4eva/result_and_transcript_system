  <!-- The Bootstrap Modal -->
  <div class="modal fade" id="myBootstrapModal">
    <div class="modal-dialog">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h4 class="modal-title">Modal Heading</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
          Modal body..
          <form class="form-inline my-2 my-lg-0">
                <input id="myInputBS" class="form-control mr-sm-2" onkeyup="mySearchFunctionBS();" type="text" placeholder="Search for Family Member" aria-label="Search">
                <button class="btn btn-outline-success my-2 my-sm-0"  type="submit">Search</button>
              </form>

                <ul id="myULSearchBS" class="list-group" style="display: none;">
                  <li class="list-group-item "><a href="#">Adele</a></li>
                  <li class="list-group-item"><a href="#">Agnes</a></li>

                  <li class="list-group-item"><a href="#">Billy</a></li>
                  <li class="list-group-item"><a href="#">Bob</a></li>

                  <li class="list-group-item"><a href="#">Calvin</a></li>
                  <li class="list-group-item"><a href="#">Christina</a></li>
                  <li class="list-group-item"><a href="#">Cindy</a></li>
                </ul> 


              </div>
              <p class="card-text"> Take note of the unique number that will be displayed above  </p>
        </div>
        
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" id="closeBootStrapModal" class="btn btn-danger close" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>


  <!-- Bootstrap Modal Script -->
  <script>
          var modal2 = document.getElementById("myBootstrapModal");   // Get the modal   
          span2.onclick = function() {   // When the user clicks on <span> (x), close the modal
            modal2.style.display = "none";
          }  
  </script>