import React, {useState} from "react";
import {INewElement} from "../models";

interface AddElementProps {
    index: number
    onChange: (element: INewElement, index: number) => void
}

export function AddElement(props: AddElementProps) {
    const [code, setCode] = useState('');
    const [value, setValue] = useState('');

    const changeHandler = (event: React.ChangeEvent<HTMLInputElement>) => {
        setValue(event.target.value)
        props.onChange({[code]: value} as INewElement, props.index)
    }

    const changeKeyHandler = (event: React.ChangeEvent<HTMLInputElement>) => {
        setCode(event.target.value);
        props.onChange({[code]: value} as INewElement, props.index)
    }

    return (
        <>
            <div>
                <input type="text"
                       className="border py-2 px-4 mb-2 w-1/2 outline-0"
                       placeholder="Код.."
                       value={code}
                       onChange={changeKeyHandler}
                />

                <input type="text"
                       className="border py-2 px-4 mb-2 w-1/2 outline-0"
                       placeholder="Значение"
                       value={value}
                       onChange={changeHandler}
                />
            </div>
        </>
    )
}