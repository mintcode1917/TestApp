import {IElement} from "../models";

interface ElementProps{
    element: IElement
}
export function Element(props: ElementProps) {
    return (<div className="border py-2 px-4 rounded flex flex-col items-center mb-2">
        <h1 className="font-bold">{props.element.number}</h1>
        <p>{props.element.code} | {props.element.value}</p>
    </div>)
}