$(document).ready(() =>insertData(JSON.parse($("#grid-container").attr("data"))));

const insertData = (data) => {
  let cards = "";
  data.map((item) => {
    cards += `
    <div  class="col-lg-2">
             <a href="/Admin/Project/ProjectContent/${item.ProjectId}?projectApplicantId=${item.ProjectApplicantId}"  >
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/project/${item.ProjectImage}" loading="lazy" alt="${item.ProjectName}"  class="mx-auto d-block mb-3 w-100"> 
                           <div class="row">
                             <div class="col-md-12">

                               <h3 class="project-title ">${item.ProjectName}</h3>
                             </div>
                            
                           
                           </div>
                            <p class="text-muted"><span class="text-secondary font-14"><b>پیشرفت پروژه : </b></span> % ${item.Progress} 
                            </p>
                           <div class="row">
                             <div class="col-6"> 
                               <p class="text-muted">

                                 تعداد بلوک : ${item.NumberOfBlocks} 
                               </p>
                              </div>
                             <div class="col-6">
                              <p class="text-muted">

                                تعداد واحد : ${item.NumberOfUnits}
                              </p>

                             
                             </div>
                           </div>
                         
                         
                        </div>                                                                      
                    </div><!--end card-body-->
                    
                </div><!--end card-->
              </a>
            </div><!--end col-->

`;
  });

  document.getElementById("grid-container").innerHTML = cards;
};
$("#mySearchText").keyup(function () {
  let data = JSON.parse($("#grid-container").attr("data"));
    filtered = data.filter((item) => item.ProjectName.includes($(this).val()));






  insertData(filtered);
});
