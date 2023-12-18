$(document).ready(() =>insertData(JSON.parse($("#grid-container").attr("data"))));

const insertData = (data) => {
    console.log(data);
    let cards = "";
  data.map((item) => {
    cards += `
    <div id="Unit_${item.UnitId}" class="col-lg-2">
             
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/unit/${item.FileName}" loading="lazy" alt="${item.FileName}"  class="mx-auto d-block mb-3 w-100"> 
                           <div class="row">
                             <div class="col-md-8">

                               <h3 class="project-title ">${item.Title}</h3>
                             </div>
                             <div class="col-md-4">
                              <div class=" d-flex justify-content-end">                                        
                                <div class="dropdown d-inline-block" style="margin: 10px 0;">
                                    <a class="nav-link dropdown-toggle arrow-none" id="dLabel1" data-toggle="dropdown" href="#" role="button" aria-haspopup="false" aria-expanded="false">
                                        <i class="fas fa-ellipsis-v font-20 text-muted"></i>
                                    </a>
                                    <div class="dropdown-menu" aria-labelledby="dLabel1">
                                        <a class="dropdown-item" href="/Unit/UnitCopy/${item.UnitId}?floorId=${item.FloorId}&projectId=${item.ProjectId}&blockId=${item.BlockId}">کپی  </a>
                                        <a class="dropdown-item" href="/Unit/UnitEdit/${item.UnitId}">ویرایش  </a> 
                                        <a class="dropdown-item"  onclick="DeleteUnit(${item.UnitId})">حذف </a> 
                                        
                                    </div>
                                </div>
                            </div> 
                             </div>
                           
                           </div>
                            
 <div class="col-12 text-left">
                              <p >

                                 تیپ : ${item.ProjectPossibility.Title}
                              </p>

                             
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
