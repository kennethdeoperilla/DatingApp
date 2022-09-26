using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int Id);
        Task<AppUser> GetUserbyUsernameAsync(string UserName);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);

    }
}