using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanMinKGe
{
    class Work
    {
        string shareid;
        Detail detail;
        bool isMV;
    }
    class Detail
    {
        string avatar;
        int comment_num;
        List<Comment> comments;
        string content;
        string cover;
        string ctime;
        int flower_num;
        List<Flower> flower;
        int gift_num;
        int play_num;
        string playurl;
        string playurl_video;
        int score;
        string singer_name;
        string song_name;
        string tail_name;
        string uid;
    }
    class Comment
    {
        string avatar;
        string comment_id;
        string comment;
        long ctime;
        int is_owner;
        string nick;
        string reply_avatar;
        string reply_nick;
        string uid;
    }
    class Flower
    {
        string avatar;
        string nick;
        int num;
        int type;
        string uid;
    }
}
