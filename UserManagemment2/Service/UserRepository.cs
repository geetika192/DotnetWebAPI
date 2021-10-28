using System.Collections.Generic;
using System;
using UserManagemment2.Repository;
using UserManagemment2.Domain;

namespace UserManagemment2.Service
{
    public class UserRepository : IUserRepository //business logic layer
    {
        IRepository<User> userRepository;
        IRepository<UserProfile> userProfileRepository;
        public UserRepository(IRepository<User> _userRepository, IRepository<UserProfile> _userProfileRepository)
        {
            userRepository=_userRepository;
            userProfileRepository=_userProfileRepository;
        }
        void IUserRepository.DeleteUser(long id)
        {
            //first we need to delete from userprofile
           UserProfile userprofile=userProfileRepository.Get(id);
           userProfileRepository.Remove(userprofile);

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