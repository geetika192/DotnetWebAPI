using System.Collections.Generic;
using userManagement.Domain;
using System;
using userManagement.Repository;

namespace userManagement.Service
{
    public class UserRepository : IUserRepository
    {
        IRepository<User> userRepository;
        IRepository<UserProfile> userProfileRepository;
        public UserRepository(IRepository<User> _userRepository, IRepository<UserProfile> _userProfileRepository)
        {
            userRepository = _userRepository;
            userProfileRepository = _userProfileRepository;
        }
        void IUserRepository.DeleteUser(long id)
        {
            //first we need to delete from the dependent(userprofile) table
           UserProfile userProfile=userProfileRepository.Get(id);
           userProfileRepository.Remove(userProfile);
           //then delete from user table
           User user=userRepository.Get(id);
           userRepository.Remove(user);
           userRepository.SaveChanges();
        }

        User IUserRepository.GetUser(long id)
        {
           return userRepository.Get(id);
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            return userRepository.GetAll();
        }

        int IUserRepository.InsertUser(User user)
        {
           return userRepository.Insert(user);
        }

        void IUserRepository.UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}