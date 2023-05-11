import React from "react";
import {AddElement} from "./AddElement";
import {useNewList} from "../hooks/newList";
import axios from "axios";
import {INewElement} from "../models";

export function AddList() {
    const newList = useNewList();
    function add(){
        newList.addNewElement({} as INewElement);
    }

    const submitHandler = async (event:React.FormEvent) =>{
        await axios.post<INewElement[]>('http://localhost:5235/Test/PutList', newList.list);
    }

    let updateData = (value:INewElement,index: number) => {
        newList.updateNewElement(value, index);
    }

    return (
        <form onSubmit={submitHandler}>
            <h1 className="text-center mb-2">Добавить список</h1>
            {newList.list.map((el,index) => <AddElement index={index} onChange={updateData}/>)}
            <button type="button" className="py-2 px-4 border bg-green-400 w-1/4"
                    onClick={add}>+
            </button>
            <button type="submit" className="py-2 px-4 border bg-blue-400 w-3/4">Отправить список</button>
        </form>
    )
}