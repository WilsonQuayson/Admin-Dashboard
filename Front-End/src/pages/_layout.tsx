import Link from "next/link";
import { ReactElement } from "react";

const Layout = ({ children } : {children: ReactElement}) => {
    return (
      <section className="max-h-screen overflow-hidden flex gap-4 p-4 bg-pastel-300 font-sans">
        <section className="bg-pastel-100 w-72 h-[calc(100vh-2rem)] rounded-3xl p-3">
            <section className="w-full h-20 flex">
                <img src="https://api.dicebear.com/9.x/identicon/svg?seed=Admin" alt="" className="rounded-full border-2 border-neutral-200 w-20 h-20" />
                <section className="w-full h-full pl-4">
                    <h1 className="text-neutral-400 uppercase font-medium mt-3">Administrator</h1>
                    <p className="text-neutral-600 mt-1 font-medium">John Doe</p>
                </section>
            </section>
            <section className="mt-12 pl-2 flex flex-col justify-between h-4/5">
                <section>
                    <nav className="">
                        <p className="uppercase font-medium text-neutral-400 text-sm">main</p>
                        <ul className="flex flex-col gap-6 mt-5">
                            <li>
                                <Link href="" className="flex flex-row gap-2 pl-4">
                                    <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5"/>
                                    </svg>
                                    <p className="uppercase font-medium text-neutral-500">Dashboard</p>
                                </Link>
                            </li>
                            <li>
                                <Link href="" className="flex flex-row gap-2 pl-4">
                                    <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 4v15a1 1 0 0 0 1 1h15M8 16l2.5-5.5 3 3L17.273 7 20 9.667"/>
                                    </svg>
                                    <p className="uppercase font-medium text-neutral-500">Users</p>
                                </Link>
                            </li>
                            <li>
                                <Link href="" className="flex flex-row gap-2 pl-4">
                                    <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5"/>
                                    </svg>
                                    <p className="uppercase font-medium text-neutral-500">Values</p>
                                </Link>
                            </li>
                        </ul>
                    </nav>
                    <nav className="mt-4">
                        <p className="uppercase font-medium text-neutral-400 text-sm">extra</p>
                        <ul className="flex flex-col gap-6 mt-5">
                            <li>
                                <Link href="" className="flex flex-row gap-2 pl-4">
                                    <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5"/>
                                    </svg>
                                    <p className="uppercase font-medium text-neutral-500">Dashboard</p>
                                </Link>
                            </li>
                            <li>
                                <Link href="" className="flex flex-row gap-2 pl-4">
                                    <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5"/>
                                    </svg>
                                    <p className="uppercase font-medium text-neutral-500">Dashboard</p>
                                </Link>
                            </li>
                        </ul>
                    </nav>
                </section>
                <section>
                    <p className="uppercase font-medium text-neutral-400 text-sm">Account</p>
                    <button className="uppercase font-medium flex gap-2 pl-4 mt-4">
                        <svg className="w-6 h-6 text-neutral-500 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
                            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5"/>
                        </svg>
                        <p className="uppercase font-medium text-neutral-500">Logout</p>
                    </button>
                </section>
            </section>
        </section>
        <section className="flex-1 bg-pastel-100 rounded-3xl p-4 overflow-hidden">
            {children}
        </section>
      </section>
    );
}
  
export default Layout;