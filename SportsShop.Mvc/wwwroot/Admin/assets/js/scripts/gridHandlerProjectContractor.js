$(document).ready(() => insertData(JSON.parse($("#grid-container").attr("data"))));

const insertData = (data) => {
    console.log(data);
    let cards = "";
    data.map((item) => {
        if (item.Employer) {
            cards += `
    <div id="ProjectContractor_${item.ProjectContractorId}" class="col-lg-2">
             
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/contractor/${item.Contractor.File3}" loading="lazy" alt="${item.Contractor.Name}"  class="mx-auto d-block mb-3 w-100" >
                           <div class="row">
                             <div class="col-md-8">

                               <h6 style="font-size: 13px !important;" class="project-title ">${item.Contractor.Name} - ${item.GroupCostDetail.Title}</h6>
                             </div>
                             <div class="col-md-4">
                              <div class=" d-flex justify-content-end">                                        
                                <div class="dropdown d-inline-block" style="margin: 10px 0;">
                                    <a class="nav-link dropdown-toggle arrow-none" id="dLabel1" data-toggle="dropdown" href="#" role="button" aria-haspopup="false" aria-expanded="false">
                                        <i class="fas fa-ellipsis-v font-20 text-muted"></i>
                                    </a>
                                    <div class="dropdown-menu" aria-labelledby="dLabel1">
                                       <a class="dropdown-item" href="/ProjectEmployer/ProjectEmployerEdit/${item.ProjectContractorId}">ویرایش  </a>
                                        <a class="dropdown-item"  onclick="DeleteProjectContractor(${item.ProjectContractorId})">حذف </a>
                                        
                                    </div>
                                </div>
                            </div> 
                             </div>
                           
                           </div>
                            
                           
 <div class="col-12 text-center">
                               <p class="text-muted"><span class="text-secondary font-14"><b>کارفرما </b></span> 
                            </p>
                              </div>

                           </div>
                         
                         
                    </div><!--end card-body-->
                    
                </div><!--end card-->
              
            </div><!--end col-->

`;

        }


        else {
            cards += `
    <div id="ProjectContractor_${item.ProjectContractorId}" class="col-lg-2">
             
                <div class="card grid-shadow">
                    <div class="card-body p-0">                                        
                        
                        <div class="text-center project-card">
                            <img src="/contractor/${item.Contractor.File3}" loading="lazy" alt="${item.Contractor.Name}"  class="mx-auto d-block mb-3 w-100"> 
                           <div class="row">
                             <div class="col-md-8">

                               <h6 style="font-size: 13px !important;" class="project-title ">${item.Contractor.Name}  - ${item.GroupCostDetail.Title}</h6>
                             </div>
                             <div class="col-md-4">
                              <div class=" d-flex justify-content-end">                                        
                                <div class="dropdown d-inline-block" style="margin: 10px 0;">
                                    <a class="nav-link dropdown-toggle arrow-none" id="dLabel1" data-toggle="dropdown" href="#" role="button" aria-haspopup="false" aria-expanded="false">
                                        <i class="fas fa-ellipsis-v font-20 text-muted"></i>
                                    </a>
                                    <div class="dropdown-menu" aria-labelledby="dLabel1">
                                        <a class="dropdown-item" href="/ContractorStatusReport/Index/${item.ProjectContractorId}?projectId=${item.ProjectId}">صورت وضعیت  </a>
                                        <a class="dropdown-item" href="/ProjectContractor/Prepayment/${item.ProjectContractorId}"> قرار داد / پیش پرداخت</a>
                                        <a class="dropdown-item" href="/ProjectContractor/ProjectContractorEdit/${item.ProjectContractorId}">ویرایش  </a> 
                                        <a class="dropdown-item"  onclick="DeleteProjectContractor(${item.ProjectContractorId})">حذف </a> 
                                        
                                    </div>
                                </div>
                            </div> 
                             </div>
                           
                           </div>
                              
 <div class="col-12 text-center">
                               <p class="text-muted"><span class="text-secondary font-14"><b>پیمانکار </b></span>
                            </p>
                              </div>

                           </div>
                         
                         
                        </div>                                                                      
                    </div><!--end card-body-->
                    
                </div><!--end card-->
              
            </div><!--end col-->

`;
        }


    });

    document.getElementById("grid-container").innerHTML = cards;
};
$("#mySearchText").keyup(function () {
    let data = JSON.parse($("#grid-container").attr("data"));
    filtered = data.filter((item) => item.FullName.includes($(this).val()));






    insertData(filtered);
});
