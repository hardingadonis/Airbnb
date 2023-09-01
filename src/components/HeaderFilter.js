import ArrowLeft from "./arrowLeft";
import IconU2 from "./iconU2";

const tw = {
  container: `HEADER sticky top-0 zmax3 ||    h-12 7:h-16 || border-b-c1 border-solid 
  border-lgray || flex justify-center items-center bg-white `,
  div1: `absolute || left-4 w-c32 h-c32 || flex justify-center 
  items-center || text-black222 cursor-pointer hover:bg-gray-200 rounded-full`,
  span1: `text-base weight-800`,
};

export default function HeaderFilter({title,handleOnClick}) {
  
  return (
    <div className={tw.container}>
      <div className={tw.div1} onClick={handleOnClick}>
        <IconU2/>
      </div>
      <span className={tw.span1}>{title}</span>
    </div>
  );
}