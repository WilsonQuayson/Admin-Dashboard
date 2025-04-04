import { useState } from "react";

interface ModalProps {
    isOpen: boolean;
    onClose: () => void;
    children: React.ReactNode;
}

const StudentModal = ({isOpen, onClose, children} : ModalProps) => {
    if(!isOpen) return null;

    return(
        <section className={`fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50`}>
            <section className="bg-white w-1/3 rounded-lg shadow-lg p-4 relative">
                <div className="flex justify-end">
                    <svg className="hover:cursor-pointer w-6 h-6 text-red-600 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" viewBox="0 0 24 24">
                        <path onClick={onClose} fill-rule="evenodd" d="M2 12C2 6.477 6.477 2 12 2s10 4.477 10 10-4.477 10-10 10S2 17.523 2 12Zm7.707-3.707a1 1 0 0 0-1.414 1.414L10.586 12l-2.293 2.293a1 1 0 1 0 1.414 1.414L12 13.414l2.293 2.293a1 1 0 0 0 1.414-1.414L13.414 12l2.293-2.293a1 1 0 0 0-1.414-1.414L12 10.586 9.707 8.293Z" clip-rule="evenodd"/>
                    </svg>
                </div>
                {children}
            </section>
        </section>
    )
}

export default StudentModal;