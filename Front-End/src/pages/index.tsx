import { useEffect, useState } from "react";
import { Student } from "../../types";
import ProgressCircle from "@/components/ProgressCircle";

const Home = () => {
  const [users, setUsers] = useState<Student[]>([]);
  const [search, setSearch] = useState("");
  const [loading, setLoading] = useState(true);
  const [selectedStudent, setSelectedStudent] = useState<Student | null>();

  const fetchData = async() => {
    try{
      const response = await fetch('https://localhost:7063/api/Students')
      if(response.ok){
        const data = await response.json();
        const users: Student[] = data;
        setUsers(users);
        setLoading(false)
      }
    }catch(e){

    }
  }

  useEffect(() => {
    fetchData();
  }, []);

  if(loading){
    return (
      <>
        <p>...Loading</p>
      </>
    )
  }

  return(
    <main className="h-full overflow-hidden flex flex-col">
        <div className="flex justify-between">
          <input type="text" placeholder="search..." value={search} onChange={(e) => setSearch(e.target.value)} className="p-1 pl-6 shadow-sm rounded-2xl w-60 focus:outline-none"/>
          <button className="bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded text-sm mr-2">Create Student</button>
        </div>
        <div className={`${selectedStudent ? "h-[30rem]" : "h-full"} overflow-x-auto sm:rounded-lg mt-2 flex flex-col justify-between pb-2 bg-red-300`}>
          <table className="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-400 shadow-md">
            <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
              <tr>
                <th scope="col" className="px-6 py-3 text-center">
                  <p>Name</p>
                </th>
                <th scope="col" className="px-6 py-3 text-center">
                  <p>Birthdate</p>
                </th>
                <th scope="col" className="px-6 py-3 text-center">
                  <p>Email</p>
                </th>
                <th scope="col" className="px-6 py-3 text-center">
                  <p>Performance</p>
                </th>
                <th scope="col" className="px-6 py-3 text-center">
                  <p>Action</p>
                </th>
              </tr>
            </thead>
            <tbody>
              {
                users!.map((student, index) => (
                  <tr key={index} className="bg-white border-b dark:bg-gray-800 dark:border-gray-700">
                    <td className="px-6 py-4 font-medium whitespace-nowrap dark:text-white flex gap-4 justify-center">{student.firstName} {student.lastName}</td>
                    <td className="px-6 py-4 text-center">{student.dateOfBirth.split("T")[0]}</td>
                    <td className="px-6 py-4 text-center">{student.email}</td>
                    <td className="px-6 py-4 text-center">{student.performance}</td>
                    <td className="px-6 py-4 text-blue-600 text-center" onClick={() => setSelectedStudent(student)}>View</td>
                  </tr>
                ))
              }
            </tbody>
          </table>
        </div>
        {/* Selected Student Section */}
      {selectedStudent && (
        <div className="mt-4 p-4 flex-1 bg-white shadow rounded-lg text-gray-500">
          <div className="flex justify-end">
            <svg onClick={() => setSelectedStudent(null)} className="hover:cursor-pointer w-6 h-6 text-red-600 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" viewBox="0 0 24 24">
              <path fill-rule="evenodd" d="M2 12C2 6.477 6.477 2 12 2s10 4.477 10 10-4.477 10-10 10S2 17.523 2 12Zm7.707-3.707a1 1 0 0 0-1.414 1.414L10.586 12l-2.293 2.293a1 1 0 1 0 1.414 1.414L12 13.414l2.293 2.293a1 1 0 0 0 1.414-1.414L13.414 12l2.293-2.293a1 1 0 0 0-1.414-1.414L12 10.586 9.707 8.293Z" clip-rule="evenodd"/>
            </svg>
          </div>
          <div className="flex gap-4">
            <img src={`https://api.dicebear.com/9.x/identicon/svg?seed=${selectedStudent.lastName}`} alt="" className="h-20 w-20" />
            <div className="mt-2">
              <h1 className="font-semibold text-2xl text-gray-600">{selectedStudent.firstName} {selectedStudent.lastName}</h1>
              <p>{selectedStudent.email}</p>
            </div>
          </div>
          <div className="flex mt-4">
            <div className="w-2/4 h-full"> 
              <p><span className="font-semibold text-gray-600">ID:</span> {selectedStudent.id}</p>
              <p><span className="font-semibold text-gray-600">Birthdate:</span> {selectedStudent.dateOfBirth.split("T")[0]}</p>
            </div>
            <div className="w-2/4 h-full"> 
              <ProgressCircle percentage={selectedStudent.performance} />
            </div>
          </div>
        </div>
      )}
    </main>
  )
}

export default Home;