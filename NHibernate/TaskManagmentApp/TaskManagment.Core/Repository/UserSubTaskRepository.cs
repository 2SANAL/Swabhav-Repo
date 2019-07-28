using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Testing.Values;
using NHibernate.Linq;
using TaskManagment.Core.BusinessModel;

namespace TaskManagment.Core.Repository
{
    public class UserSubTaskRepository
    {
        public bool AddSubTask(UserSubTask userSubTask)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(userSubTask);
                    transaction.Commit();
                    return true;
                }
            }
        }

        public List<UserSubTask> GetAllSubTasks(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                var subTasks = session.Query<UserSubTask>().Where(m => m.UserTask.Id == id).ToList();
                return subTasks;
            }
        }

        public UserSubTask GetTaskById(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                var subTask = session.Query<UserSubTask>().Single(m => m.Id == id);
                return subTask;
            }
        }

        public bool RemoveTask(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var subTask = GetTaskById(id);
                    session.Delete(subTask);
                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool UpdateTask(UserSubTask userTask)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var task = GetTaskById(userTask.Id);

                    task.SubModifyDate = userTask.SubModifyDate;
                    task.SubTaskDescription = userTask.SubTaskDescription;
                    task.SubTaskTitle = userTask.SubTaskTitle;

                    session.SaveOrUpdate(task);
                    transaction.Commit();
                    return true;
                }

            }
        }
    }
}
