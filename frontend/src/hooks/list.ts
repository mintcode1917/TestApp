import {useEffect, useState} from "react";
import {IElement} from "../models";
import axios from "axios";

export function useList(){
    const [list, setList] = useState<IElement[]>([]);
    async function fetchList(){
        const resp = await axios.get<IElement[]>('http://localhost:5235/Test/GetList?pageNumber=1&pageSize=3');
        setList(resp.data);
    }



    useEffect(()=>{
        fetchList();
    },[]);

    return list;
}