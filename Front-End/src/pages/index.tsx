import { useEffect, useState } from "react";
import { Students } from "../../types";

const Home = () => {
  const [users, setUsers] = useState<Students[]>([]);
  const [search, setSearch] = useState("");

  const fetchData = async() => {
    try{
      const response = await fetch('https://localhost:7063/api/Students')
      if(response.ok){
        const data = await response.json();
        const users: Students[] = data;
        setUsers(users);
        console.log(users);
      }
    }catch(e){

    }
  }

  useEffect(() => {
    fetchData();
  }, []);

  if(!users){
    return (
      <>
        <p>...Loading</p>
      </>
    )
  }

  return(
    <main className="h-full">
        <div className="">
          <input type="text" placeholder="search..." value={search} onChange={(e) => setSearch(e.target.value)} className="p-1 pl-6 shadow-sm rounded-2xl w-60 focus:outline-none"/>
        </div>
        <div className="h-[51rem] overflow-x-auto sm:rounded-lg mt-2 flex flex-col justify-between pb-2">
          <table className="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-400 shadow-md">
              <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
                  <tr>
                      <th scope="col" className="px-6 py-3">
                      Name
                      </th>
                      <th scope="col" className="px-6 py-3">
                          <p>Color</p>
                      </th>
                      <th scope="col" className="px-6 py-3">
                          <p>Color</p>
                      </th>
                      <th scope="col" className="px-6 py-3">
                          <p>Color</p>
                      </th>
                      <th scope="col" className="px-6 py-3">
                          <p>Action</p>
                      </th>
                  </tr>
              </thead>
              <tbody>
                  {
                      users!.map((student, index) => (
                          <tr key={index} className="bg-white border-b dark:bg-gray-800 dark:border-gray-700">
                              <th className="px-6 py-4 font-medium text-gray-900 whitespace-nowrap dark:text-white">{student.firstName} {student.lastName}</th>
                              <td className="px-6 py-4">{}</td>
                              <td className="px-6 py-4">{}</td>
                              <td className="px-6 py-4">{}</td>
                              <td className="px-6 py-4 text-blue-600">Edit</td>
                          </tr>
                      ))
                  }
              </tbody>
          </table>
        </div>

    </main>
  )
}

export default Home;