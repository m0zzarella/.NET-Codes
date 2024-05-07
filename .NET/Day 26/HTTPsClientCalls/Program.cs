using HTTPsClientCalls;
//using static HTTPsClientCalls.PostDataAPI;




#region PostAPI
//PostDataAPI postData    = new PostDataAPI();

//      var data = postData.ConsumePostData();

//foreach (var i in data)
//{
//    Console.WriteLine(i.userId);
//    Console.WriteLine(i.id);
//    Console.WriteLine(i.title);
//    Console.WriteLine(i.body);
//    Console.WriteLine("--------------------------");
//}
#endregion

#region CommentsAPI
//CommentsDataAPI commentsData = new CommentsDataAPI();

//var data = commentsData.ConsumeCommentsData();

//foreach (var i in data)
//{
//    Console.WriteLine(i.postId);
//    Console.WriteLine(i.id);
//    Console.WriteLine(i.name);
//    Console.WriteLine(i.email);
//    Console.WriteLine(i.body);
//    Console.WriteLine("--------------------------");
//}
#endregion

#region fakeAPI
//fakeAPI fakeData = new fakeAPI();

//var data = fakeData.ConsumeFakeAPI();

//foreach (var i in data)
//{

//    Console.WriteLine($"ID:  {i.id}");
//    Console.WriteLine($"Title: {i.title}");
//    Console.WriteLine($"Price: {i.price}");
//    Console.WriteLine($"Description: {i.description}");
//    Console.WriteLine("--------------------------");
//}
#endregion

#region PostByID

//PostDataAPI postData = new PostDataAPI();

//var data = postData.ConsumePostData();
//Console.WriteLine("Enter Post ID: ");
//int id = Convert.ToInt32(Console.ReadLine());

//try
//{
//    PostDataAPI postAPI = postData.GetPostById(id);
//    Console.WriteLine("ID: " + postAPI.id);
//    Console.WriteLine("userID: " + postAPI.userId);
//    Console.WriteLine("Title: " + postAPI.title);
//    Console.WriteLine("Body: " + postAPI.body);
//}
//catch(Exception es) { throw new Exception("hehe"); }
#endregion

#region FakebyID

fakeAPI fakeData = new fakeAPI();

var data = fakeData.ConsumeFakeAPI();
Console.WriteLine("Enter Product ID: ");
int id = Convert.ToInt32(Console.ReadLine());

try
{
    fakeAPI fakeAPI = fakeData.GetFakeById(id);
    Console.WriteLine("ID: " + fakeAPI.id);
    Console.WriteLine("Title: " + fakeAPI.title);
    Console.WriteLine("Description: " + fakeAPI.description);
    Console.WriteLine("--------------------------");
}
catch (Exception es) { throw new Exception("hehe"); }

#endregion



