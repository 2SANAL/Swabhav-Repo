using System;
using System.Collections.Generic;
using FluentNHibernate.Testing.Values;
using TaskManagment.Core.BusinessModel;
using TaskManagment.Core.Repository;

namespace TaskManagment.Core.Services
{
    public class UserTaskService
    {
        private readonly UserTaskRepository _userTaskRepository;

        public UserTaskService()
        {
            _userTaskRepository = new UserTaskRepository();
        }

        public List<UserTask> GetAllTasks(Guid id)
        {
            return _userTaskRepository.GetAllTask(id);
        }

        public bool AddTask(UserTask userTask)
        {
            if (userTask != null)
            {
                var result = _userTaskRepository.AddTask(userTask);
                return result;
            }
            else
            {
                return false;
            }
        }

        public UserTask GetTaskById(Guid id)
        {
            var result = _userTaskRepository.GetTaskById(id);
            return result;
        }

        public bool RemoveTask(Guid id)
        {
            var result = _userTaskRepository.RemoveTask(id);
            return result;
        }
        public bool UpdateTask(UserTask userTask,Guid id)
        {
            if (userTask != null)
            {
                var result = _userTaskRepository.UpdateTask(userTask,id);
                return result;
            }
            else
            {
                return false;
            }
        }
    }
}