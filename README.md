# DotNet7.FilterSortingPagingUsingSieve

https://www.nuget.org/packages/Sieve/

https://github.com/Biarity/Sieve

```
GET /GetPosts

?sorts=     LikeCount,CommentCount,-created         // sort by likes, then comments, then descendingly by date created 
&filters=   LikeCount>10, Title@=awesome title,     // filter to posts with more than 10 likes, and a title that contains the phrase "awesome title"
&page=      1                                       // get the first page...
&pageSize=  10                                      // ...which contains 10 posts

```

http://localhost:54641/GetProducts?Filters=Name%40%3DU&Sorts=-name&Page=1&PageSize=10