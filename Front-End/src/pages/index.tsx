import { useEffect, useState } from "react";

const Home = () => {
  const [users, setUsers] = useState<User[]>([]);
  const [search, setSearch] = useState("");
  const [currentPage, setCurrentPage] = useState(1);

  const itemsPerPage = 13;

  // Calculate the range of items to display
  const indexOfLastItem = currentPage * itemsPerPage;
  const indexOfFirstItem = indexOfLastItem - itemsPerPage;
  const currentItems = users.slice(indexOfFirstItem, indexOfLastItem);

  const totalPages = Math.ceil(users!.length / itemsPerPage);

  const handlePageChange = (page: number) => {
    setCurrentPage(page);
  };

  const fetchData = async() => {
    try{
      const response = await fetch('https://dummyjson.com/users')
      if(response.ok){
        const data:MockApi = await response.json();
        const users: User[] = data.users;
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
                      currentItems!.map((user, index) => (
                          <tr className="bg-white border-b dark:bg-gray-800 dark:border-gray-700">
                              <th className="px-6 py-4 font-medium text-gray-900 whitespace-nowrap dark:text-white">{user.firstName} {user.lastName}</th>
                              <td className="px-6 py-4">{user.age}</td>
                              <td className="px-6 py-4">{user.address.address}</td>
                              <td className="px-6 py-4">{user.email}</td>
                              <td className="px-6 py-4 text-blue-600">Edit</td>
                          </tr>
                      ))
                  }
              </tbody>
          </table>
          <div className="flex justify-between w-full mt-4">
            <button onClick={() => handlePageChange(currentPage - 1)} className="px-4 py-2 mx-2 text-white rounded bg-blue-500 hover:bg-blue-600" disabled={currentPage === 1 || search !== ""}>Previous</button>
            <p className="px-4 py-2">Page {currentPage} of {totalPages}</p>
            <button onClick={() => handlePageChange(currentPage + 1)} className="px-4 py-2 mx-2 text-white rounded bg-blue-500 hover:bg-blue-600" disabled={currentPage === totalPages || search !== ""}>Previous</button>   
          </div>
        </div>

    </main>
  )
}

export default Home;