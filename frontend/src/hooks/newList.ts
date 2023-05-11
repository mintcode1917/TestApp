import {useState} from "react";
import {INewElement} from "../models";

export function useNewList(){
    const [list, setList] = useState<INewElement[]>([]);

    function updateNewElement(newElement:INewElement, index:number) {
        setList([...list.slice(0, index), newElement,...list.slice(index + 1)]);
    }

    function addNewElement(newElement: INewElement){
        setList(prev=>[...prev, newElement]);
    }

    return {list, addNewElement, updateNewElement}
}