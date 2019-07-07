using System;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;

namespace Reddit.Core.Data.Mappers
{
    public static class UserProfileMapper
    {
        public static UserModel DataToModel(this UserResponseDto data, UserModel model = null)
        {
            if (data == null)
                return null;

            if (model == null)
                model = new UserModel();

            model.UserName = data.name;
            model.LogoUrl = data.icon_img.Split(new char[] { '?' })[0];

            return model;
        }
    }
}
