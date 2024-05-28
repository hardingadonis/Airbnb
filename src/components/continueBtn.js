import { Link } from "react-router-dom";

export default function ContinueBtn({ isGray, handleOnClick }) {
  return (
    <Link
      to={window.location.pathname.replace("/Airbnb", "") === "/login" ? "/" : ""}
      className={`BUTTON ||  w-full  py-c12 ||  flex justify-center items-center
      || weight-800 text-white || rounded-md  cursor-pointer
      ${isGray === true ? "bg-lgrayd" : "main-gradient"}`}
      onClick={handleOnClick}
    >
      Continue
    </Link>
  );
}