using System;
using System.Collections.Generic;
using TaskManagment.Core.BusinessModel;
using TaskManagment.Core.Repository;

namespace TaskManagment.Core.Services
{
    public class UserSubTaskService
    {

        private readonly UserSubTaskRepository _userSubTaskRepository;

        public UserSubTaskService()
        {
            _userSubTaskRepository = new UserSubTaskRepository();
        }

        public List<UserSubTask> GetAllTasks(Guid id)
        {
            return _userSubTaskRepository.GetAllSubTasks(id);
        }
        public bool AddSubTask(UserSubTask userSubTask)
        {
            if (userSubTask != null)
            {
                var result = _userSubTaskRepository.AddSubTask(userSubTask);
                return result;
            }
            else
            {
                return false;
            }
        }

        public UserSubTask GetTaskById(Guid id)
        {
            var result = _userSubTaskRepository.GetTaskById(id);
            return result;
        }

        public bool RemoveTask(Guid id)
        {
            var result = _userSubTaskRepository.RemoveTask(id);
            return result;
        }
        public bool UpdateTask(UserSubTask userSubTask)
        {
            if (userSubTask != null)
            {
                var result = _userSubTaskRepository.UpdateTask(userSubTask);
                return result;
            }
            else
            {
                return false;
            }
        }
    }
}
