using System;
using System.Collections.Generic;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Services
{
    public class ParameterService: IParameterService
    {
        private  readonly IParameterRepository _parameterRepository;

        public ParameterService(IParameterRepository parameterRepository)
        {
            _parameterRepository = parameterRepository;
        }

        public List<Parameter> GetAll()
        {
            return _parameterRepository.GetAll();
        }

        public void AddParameter(Parameter parameter)
        {
            _parameterRepository.AddParameter(parameter);
        }

        public Parameter GetParameterById(int parameterId)
        {
            return _parameterRepository.GetParameterById(parameterId);
        }

        public void UpdateParameter(Parameter parameter)
        {
            parameter.UpdateDate = DateTime.Now;
            _parameterRepository.UpdateParameter(parameter);
        }

        public bool IsExist(int parameterId)
        {
            return _parameterRepository.IsExist(parameterId);
        }

        public RequestResult DeleteParameter(int parameterId)
        {
            var parameter = GetParameterById(parameterId);
            if (parameter == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

            if (IsExist(parameterId))
                return new RequestResult(false, RequestResultStatusCode.InternalServerError, "پارامتر کالا در سیستم استفاده شده است!");

            parameter.DeleteDate = DateTime.Now;
            UpdateParameter(parameter);
            return new RequestResult(true, RequestResultStatusCode.Success, "پارامتر کالا با موفقیت حذف شد.");
        }
    }
}