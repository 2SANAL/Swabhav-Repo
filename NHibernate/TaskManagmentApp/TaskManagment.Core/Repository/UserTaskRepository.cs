using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Testing.Values;
using NHibernate.Linq;
using TaskManagment.Core.BusinessModel;

namespace TaskManagment.Core.Repository
{
    public class UserTaskRepository
    {
        public bool AddTask(UserTask userTask)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    session.Save(userTask);
                    transaction.Commit();
                    return true;
                }
            }
        }

        public List<UserTask> GetAllTask(Guid id)
        {
            using (var session=Helper.OpenSession())
            {
                var tasks = session.Query<UserTask>().Where(m => m.User.Id == id).ToList();
                return tasks;
            }
        }

        public UserTask GetTaskById(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                var task = session.Query<UserTask>().Single(m => m.Id == id);
                return task;
            }
        }

        public bool RemoveTask(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var task = GetTaskById(id);
                    session.Delete(task);
                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool UpdateTask(UserTask userTask, Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var task = GetTaskById(id);

                    task.ModifyDate = userTask.ModifyDate;
                    task.TaskDescription = userTask.TaskDescription;
                    task.TaskTitle = userTask.TaskTitle;

                    session.SaveOrUpdate(task);
                    transaction.Commit();
                    return true;
                }

            }
        }
    }
}