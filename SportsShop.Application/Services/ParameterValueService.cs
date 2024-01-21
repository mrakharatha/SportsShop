using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Services
{
    public class ParameterValueService: IParameterValueService
    {
        private readonly IParameterValueRepository _parameterValueRepository;

        public ParameterValueService(IParameterValueRepository parameterValueRepository)
        {
            _parameterValueRepository = parameterValueRepository;
        }

        public List<ParameterValue> GetAll(int parameterId)
        {
            return _parameterValueRepository.GetAll(parameterId);
        }

        public void AddParameterValue(ParameterValue parameterValue)
        {
            _parameterValueRepository.AddParameterValue(parameterValue);
        }

        public ParameterValue GetParameterValueById(int parameterValueId)
        {
            return _parameterValueRepository.GetParameterValueById(parameterValueId);
        }

        public void UpdateParameterValue(ParameterValue parameterValue)
        {
            parameterValue.UpdateDate=DateTime.Now;
            _parameterValueRepository.UpdateParameterValue(parameterValue);
        }

        public RequestResult DeleteParameterValue(int parameterValueId)
        {

            var parameterValue = GetParameterValueById(parameterValueId);
            if (parameterValue == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

            //if (IsExist(parameterId))
            //    return new RequestResult(false, RequestResultStatusCode.InternalServerError, "پارامتر کالا در سیستم استفاده شده است!");

            parameterValue.DeleteDate = DateTime.Now;
            UpdateParameterValue(parameterValue);
            return new RequestResult(true, RequestResultStatusCode.Success, "مقادیر پارامتر کالا با موفقیت حذف شد.");
        }
    }
}