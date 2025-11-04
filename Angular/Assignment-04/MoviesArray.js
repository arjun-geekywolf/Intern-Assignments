let movies = [
  { MovieName: "The Great Adventure", ActorName: "John Smith", ReleaseDate: "2023-01-15" },
  { MovieName: "Mystery in the Woods", ActorName: "Emily Johnson", ReleaseDate: "2022-09-28" },
  { MovieName: "Love and Destiny", ActorName: "Michael Brown", ReleaseDate: "2023-05-02" },
  { MovieName: "City of Shadows", ActorName: "Sophia Williams", ReleaseDate: "2023-03-12" },
  { MovieName: "The Last Stand", ActorName: "William Davis", ReleaseDate: "2022-11-07" },
  { MovieName: "Echoes of Time", ActorName: "Olivia Wilson", ReleaseDate: "2022-12-19" }
];

// 1. List the movie name along with the actor name of those movies released in the year 2022

const result= movies.filter(x => x.ReleaseDate.startsWith("2022")).map(x => `${x.MovieName} - ${x.ActorName}`);
console.log(result);


// 2. List the movie names released in the year 2023 where the actor is William Davis.


const result2 = movies.filter(x => x.ReleaseDate.startsWith("2023") && x.ActorName === "William Davis").map(x => x.MovieName);
console.log(result2);


// 3.Retrieve the Actor name and release date of the movie “The Last Stand”

const result3 = movies.find(x => x.MovieName === "The Last Stand");
console.log(`Actor Name: ${result3.ActorName}, Release Date: ${result3.ReleaseDate}`);


// 4. Check whether there is any movie in the list with actor name “John Doe”

const result4 = movies.some(x => x.ActorName === "John Doe");
console.log(result4);


// 5. Display the count of movies where the actor name is "Sophia Williams"

const result5 = movies.filter(x => x.ActorName === "Sophia Williams").length;
console.log(result5);


// 6. Insert an element { "MovieName": "The Final Stage", "ActorName": "John Doe", "ReleaseDate": "2022-08-11" } as last element

movies.push({ MovieName: "The Final Stage", ActorName: "John Doe", ReleaseDate: "2022-08-11" });
console.log(movies);


// 7. Check whether there exists any duplicate movie names present in the array

const result7 = movies.length !== new Set(movies.map(m => m.MovieName)).size;
console.log(result7);


// 8. Create a new array starting from the movie "City of Shadows"

const startIndex = movies.findIndex(x => x.MovieName === "City of Shadows");
const result8 = movies.slice(startIndex);
console.log(result8);


// 9. List the distinct actor names in array

const result9 = [...new Set(movies.map(x => x.ActorName))];
console.log(result9);


// 10. Insert an element { "MovieName": "Rich & Poor", "ActorName": "Johnie Walker", "ReleaseDate": "2023-08-11" } as next element to movie “Love and Destiny”

const index = movies.findIndex(x => x.MovieName === "Love and Destiny");
movies.splice(index + 1, 0, { MovieName: "Rich & Poor", ActorName: "Johnie Walker", ReleaseDate: "2023-08-11" });
console.log(movies);


// 11. Display the count of distinct actor names in array

const result10 = new Set(movies.map(x => x.ActorName)).size;
console.log(result10);


// 12. Remove the movie named  "The Last Stand"

const indexToRemove = movies.findIndex(x => x.MovieName === "The Last Stand");
if (indexToRemove !== -1) {
  movies.splice(indexToRemove, 1);
}
console.log(movies);


// 13. Check whether all the movies are released after 2021 Dec 31

const result11 = movies.every(x => new Date(x.ReleaseDate) > new Date("2021-12-31"));
console.log(result11);


// 14. Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"

movies.find(x => x.MovieName === "City of Shadows").ReleaseDate = "2023-03-13";
console.log(movies);



// 15. Create a new array of movie names whose movie name length is greater than 10.

const result12 = movies.filter(x => x.MovieName.length > 10).map(x => x.MovieName);
console.log(result12);


