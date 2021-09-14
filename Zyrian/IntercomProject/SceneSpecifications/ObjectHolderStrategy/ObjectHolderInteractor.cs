using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy
{
    public class ObjectHolderInteractor
    {
        private ObjectAdder _objectAdder = new();
        private List<ObjectHolder> _objectHolders;
        
        private ObjectLoader _objectLoader;

        public ObjectHolderInteractor(List<ObjectHolder> objectHolders)
        {
            _objectHolders = objectHolders;
        }

        /// <summary>
        /// Добавляет хранитель в список
        /// </summary>
        public void AddPeopleHolder() => _objectHolders.Add(new PeopleHolder());

        /// <summary>
        /// Очищает список
        /// </summary>
        public void Clear() => _objectHolders.Clear();

        /// <summary>
        /// Глубокое удаление. Удаляет объекты внутри хранителя и очищает список.
        /// </summary>
        public void DeepClear()
        {
            foreach (var objectHolder in _objectHolders)
            {
                objectHolder.ClearObjects();
            }

            Clear();
        }

        /// <summary>
        /// Выдаёт загрузчик объектов
        /// </summary>
        public ObjectLoader Load()
        {
            _objectLoader = new(_objectHolders);
            return _objectLoader;
        }

        public void AddPerson(Person person)
        {
            foreach (var objectHolder in _objectHolders)
            {
                if (objectHolder is PeopleHolder)
                {
                    objectHolder.TakeObject(person);
                }
            }
        }

        public void AddObject(IntercomSceneObject intercomSceneObject)
        {
            foreach (var objectHolder in _objectHolders)
            {
                if (objectHolder is ObjectHolder)
                {
                    objectHolder.TakeObject(intercomSceneObject);
                }
            }
        }
    }
}
