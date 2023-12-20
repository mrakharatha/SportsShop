﻿using System.ComponentModel.DataAnnotations;

namespace SportsShop.Application.Helpers
{
    public enum RequestResultStatusCode
    {
        [Display(Name = "درخواست با موفقیت انجام شده است.")]
        Success = 200,

        [Display(Name = "درخواست به دلیل نحو نادرست توسط سرور قابل درک نیست.")]
        BadRequest = 400,

        [Display(Name = "درخواست به اطلاعات احراز هویت کاربر نیاز دارد.")]
        Unauthorized = 401,

        [Display(Name = "شما حق دسترسی به محتوا را ندارید!")]
        Forbidden = 403,

        [Display(Name = "سرور نمی تواند داده را پیدا کند.")]
        NotFound = 404,

        [Display(Name = "درخواست به دلیل تضاد با وضعیت فعلی منبع تکمیل نشد.")]
        Conflict = 409,

        [Display(Name = "محصول در تجمیع استفاده شده است.")]
        UseInCollection = 410,

        [Display(Name = "درخواست به دلیل نحو نادرست توسط سرور قابل درک نیست.")]
        UseInAssignment = 411,


        [Display(Name = "داده در سیستم استفاده شده است، سرور قادر به حذف آن نیست!")]
        InternalServerError = 500,

    }
}
