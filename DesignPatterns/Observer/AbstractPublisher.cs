using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class AbstractPublisher<T>
    {
        private List<ISubscriber<T>> followers;
        public AbstractPublisher(){
            followers = new List<ISubscriber<T>>();
        }

        public void AddFollower(ISubscriber<T> follower)
        {
            this.followers.Add(follower);
        }

        public void Publish(T post)
        {
            this.followers.ForEach(user => user.Notify(post));
        }
    }
}
