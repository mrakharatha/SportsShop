$(document).ready(() =>insertData(JSON.parse($("#grid-container").attr("data"))));

const insertData = (data) => {
    let cards = "";
  data.map((item) => {
    cards += `
    <div  class="col-lg-2">
             
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/gallery/${item.FileName}" loading="lazy" alt="${item.FileName}"  class="mx-auto d-block mb-3 w-100"> 
                           <div class="row">
                             <div class="col-md-12">

                               <h3 class="project-title ">${item.Title}</h3>
                             </div>
                             
                           
                           </div>
                            


                            
                           </div>
                         
                         
                    </div><!--end card-body-->
                    
                </div><!--end card-->
              
            </div><!--end col-->

`;
  });

  document.getElementById("grid-container").innerHTML = cards;
};
$("#mySearchText").keyup(function () {
  let data = JSON.parse($("#grid-container").attr("data"));
    filtered = data.filter((item) => item.Title.includes($(this).val()));






  insertData(filtered);
});
