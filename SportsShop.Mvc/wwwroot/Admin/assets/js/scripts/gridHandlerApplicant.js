$(document).ready(() =>insertData(JSON.parse($("#grid-container").attr("data"))));

const insertData = (data) => {

  let cards = "";
  data.map((item) => {
    cards += `
    <div id="Applicant_${item.ProjectApplicantId}" class="col-lg-2">
             
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/applicant/${item.ImageName}" loading="lazy" alt="${item.ImageName}"  class="mx-auto d-block mb-3 w-100"> 
                           <div class="row">
                             <div class="col-md-8">

                               <h3 style="font-size: 13px !important;" class="project-title ">${item.FullName}</h3>
                             </div>
                             <div class="col-md-4">
                              <div class=" d-flex justify-content-end">                                        
                                <div class="dropdown d-inline-block" style="margin: 10px 0;">
                                    <a class="nav-link dropdown-toggle arrow-none" id="dLabel1" data-toggle="dropdown" href="#" role="button" aria-haspopup="false" aria-expanded="false">
                                        <i class="fas fa-ellipsis-v font-20 text-muted"></i>
                                    </a>
                                    <div class="dropdown-menu" aria-labelledby="dLabel1">
                                        <a target="_blank" class="dropdown-item" href="/ProjectApplicant/Print?projectApplicantId=${item.ProjectApplicantId}">پرینت اطلاعات  </a>
                                        <a class="dropdown-item" href="/ProjectApplicant/ProjectApplicantCreate?projectApplicantId=${item.ProjectApplicantId}">ویرایش  </a> 
                                        <a class="dropdown-item"  onclick="DeleteApplicant(${item.ProjectApplicantId})">حذف </a>
                                    </div>
                                </div>
                            </div>
                             </div>

                           </div>






                        <div class="row">
                             <div class="col-6">
                               <p class="text-muted">

                               تیپ : ${item.Style}
                               </p>
                              </div>
                             <div class="col-6">
                              <p class="text-muted">

                                کد متقاضی : ${item.ProjectApplicantId}
                              </p>


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
    filtered = data.filter((item) => item.FullName.includes($(this).val()));






  insertData(filtered);
});
