const legalForm = ` <form  method="post"    class="form-parsley" enctype="multipart/form-data" action="/Applicant/ApplicantLegalCreate" >
                        <div class="form-group row">
                            <label class=" col-form-label" for="ApplicantCompanyName">نام شرکت متقاضی</label>
                            <input  autocomplete="off" class="form-control" type="text" Maxlength="200" data-parsley-max-message="نام شرکت متقاضی نمی تواند بیشتر از 200 کاراکتر باشد ."  data-parsley-required-message="لطفا نام شرکت متقاضی را وارد کنید " id="ApplicantCompanyName" required name="ApplicantCompanyName" value="">
                          
                        </div>


                     

                        <div class="form-group row">
                            <label class=" col-form-label" for="EconomicCode">کد اقتصادی</label>
                            <input  autocomplete="off"  class="form-control" type="text"  data-parsley-max-message="کد اقتصادی نمی تواند بیشتر از 200 کاراکتر باشد ."   required  data-parsley-required-message="لطفا کد اقتصادی را وارد کنید " id="EconomicCode" maxlength="200" name="EconomicCode" value="">
                           
                        </div>


                        <div class="form-group row">
                            <label class=" col-form-label" for="RegistrationNumber">شماره ثبت</label>
                            <input  autocomplete="off" class="form-control" type="text"  data-parsley-max-message="شماره ثبت نمی تواند بیشتر از 200 کاراکتر باشد ."  required  data-parsley-required-message="لطفا شماره ثبت را وارد کنید " id="RegistrationNumber" maxlength="200" name="RegistrationNumber" value="">
                           
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="CeoName">نام مدیر عامل</label>
                            <input  autocomplete="off"  class="form-control" type="text"  data-parsley-max-message="نام مدیر عامل نمی تواند بیشتر از 50 کاراکتر باشد ."   required  data-parsley-required-message="لطفا نام مدیر عامل را وارد کنید " id="CeoName" maxlength="50" name="CeoName" value="">
                            
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="MobilePhoneNumberCeo">شماره تلفن همراه مدیر عامل</label>
                            <input  autocomplete="off" class="form-control" type="text"  pattern="^(\\+98|0)?9\\d{9}$"  data-parsley-pattern-message="شماره موبایل فرمت نامناسب دارد"    data-parsley-max-message="شماره تلفن همراه مدیر عامل نمی تواند بیشتر از 11 کاراکتر باشد ."  required  data-parsley-required-message="لطفا شماره تلفن همراه مدیر عامل را وارد کنید " id="MobilePhoneNumberCeo" maxlength="11" name="MobilePhoneNumberCeo" value="">
                           
                        </div>


                        <div class="form-group row">
                            <label class=" col-form-label" for="Address">آدرس</label>
                            <input  autocomplete="off" class="form-control" type="text"   required  data-parsley-required-message="لطفا آدرس را وارد کنید " id="Address" name="Address" value="">
                           
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="PhoneNumber">شماره تلفن </label>
                            <input  autocomplete="off" class="form-control" type="text"  data-parsley-max-message="شماره تلفن  نمی تواند بیشتر از 11 کاراکتر باشد ."  required  data-parsley-required-message="لطفا شماره تلفن  را وارد کنید " id="PhoneNumber" maxlength="11" name="PhoneNumber" value="">
                           
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="PostalCode">کد پستی</label>
                            <input  autocomplete="off" class="form-control" type="text"  data-parsley-max-message="کد پستی نمی تواند بیشتر از 50 کاراکتر باشد ."  required  data-parsley-required-message="لطفا کد پستی را وارد کنید " id="PostalCode" maxlength="50" name="PostalCode" value="">
                            
                        </div>



                        <div class="form-group row">
                            <label class=" col-form-label" for="AnnouncementCompanyChanges">آگهی تغیرات شرکت</label>
                            <div class="custom-file">
                                <input type="file" class="custom-file-input"  data-parsley-required-message="لطفا آگهی تغیرات شرکت را وارد کنید " required  id="announcementCompanyChangesFile" name="announcementCompanyChangesFile" lang="fa">
                                <label class="custom-file-label">انتخاب تصویر</label>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="CompanyValueAddedCertificate">گواهی ارزش افزوده شرکت</label>
                            <div class="custom-file">
                                <input type="file" class="custom-file-input" data-parsley-required-message="لطفا گواهی ارزش افزوده شرکت را وارد کنید " required id="companyValueAddedCertificateFile" name="companyValueAddedCertificateFile" lang="fa">
                                <label class="custom-file-label">انتخاب تصویر</label>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label class=" col-form-label" for="PictureContractor">تصویر متقاضی</label>
                            <div class="custom-file">
                                <input type="file" class="custom-file-input" id="pictureContractorFile"  lang="fa">
                                <label class="custom-file-label">انتخاب تصویر</label>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label class=" col-form-label" for="Description">توضیحات</label>
                            <textarea autocomplete="off" class="form-control" rows="5"  data-parsley-max-message="توضیحات نمی تواند بیشتر از 400 کاراکتر باشد ." id="Description" maxlength="400" name="Description"></textarea>
                         
                        </div>

                        <div class="col-12 d-flex justify-content-end">
                            <button type="submit" class="btn btn-primary px-4 mb-1">ذخیره و ادامه</button>
                        </div>
                    </form> `;
const realForm = ` <form  method="post"    class="form-parsley" enctype="multipart/form-data" action="/Applicant/ApplicantRealCreate" >
                    <div class="form-group row">
                        <label class=" col-form-label" for="Name">نام  متقاضی</label>
                        <input  autocomplete="off" class="form-control" type="text"  data-parsley-max-message="نام متقاضی نمی تواند بیشتر از 200 کاراکتر باشد ."  required  data-parsley-required-message="لطفا نام  متقاضی را وارد کنید " id="Name" maxlength="200" name="Name" value="">
                        
                    </div>
                   
                    <div class="form-group row">
                        <label class=" col-form-label" for="MobilePhoneNumber">شماره تلفن همراه</label>
                        <input  autocomplete="off" class="form-control" type="text" pattern="^(\\+98|0)?9\\d{9}$"  data-parsley-pattern-message="شماره موبایل فرمت نامناسب دارد"  data-parsley-max-message="شماره تلفن همراه نمی تواند بیشتر از 11 کاراکتر باشد ."  required  data-parsley-required-message="لطفا شماره تلفن همراه را وارد کنید " id="MobilePhoneNumber" maxlength="11" name="MobilePhoneNumber" value="">
                      
                    </div>
                    <div class="form-group row">
                        <label class=" col-form-label" for="PhoneNumber">شماره تلفن </label>
                        <input  autocomplete="off" class="form-control" type="text"  data-parsley-max-message="شماره تلفن  نمی تواند بیشتر از 11 کاراکتر باشد ."  required  data-parsley-required-message="لطفا شماره تلفن  را وارد کنید " id="PhoneNumber" maxlength="11" name="PhoneNumber" value="">
                        
                    </div>
                    <div class="form-group row">
                        <label class=" col-form-label" for="Address">آدرس</label>
                        <input  autocomplete="off" class="form-control" type="text"   required  data-parsley-required-message="لطفا آدرس را وارد کنید " id="Address" name="Address" value="">
                      
                    </div>


                    <div class="form-group row">
                        <label class=" col-form-label" for="NationalCardImage">تصویر کارت ملی</label>
                        <div class="custom-file">
                            <input type="file" class="custom-file-input" data-parsley-required-message="لطفا تصویر کارت ملی را وارد کنید " required id="NationalCardImageFile" name="nationalCardImageFile" lang="fa">
                            <label class="custom-file-label">انتخاب تصویر</label>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label class=" col-form-label" for="IdCardImage">تصویر شناسنامه</label>
                        <div class="custom-file">
                            <input type="file" class="custom-file-input" data-parsley-required-message="لطفا تصویر شناسنامه را وارد کنید " required id="IdCardImageFile" name="idCardImageFile" lang="fa">
                            <label class="custom-file-label">انتخاب تصویر</label>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label class=" col-form-label" for="PictureContractor">تصویر متقاضی</label>
                        <div class="custom-file">
                            <input type="file" class="custom-file-input" id="pictureContractorFile" lang="fa">
                            <label class="custom-file-label">انتخاب تصویر</label>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label class=" col-form-label" for="Description">توضیحات</label>
                        <textarea autocomplete="off"  class="form-control" rows="5"  data-parsley-max-message="توضیحات نمی تواند بیشتر از 400 کاراکتر باشد ." id="Description" maxlength="400" name="Description"></textarea>
                       
                    </div>

                    <div class="col-12 d-flex justify-content-end">
                        <button type="submit" class="btn btn-primary px-4 mb-1">ذخیره و ادامه</button>
                    </div>
                        </form>`;



